using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera1._1
{
    public partial class FrmConsultarCarreras : Form
    {
        DBHelper oBD;
        List<Carrera> lCarreras;
        public FrmConsultarCarreras()
        {
            InitializeComponent();
            oBD = new DBHelper();
            lCarreras = new List<Carrera>();
        }

        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            RbtHabilitadas.Checked = true;
            BtnHabilitar.Enabled = false;
            cargarLista();
            TxtEstado.Enabled = false;
            TxtMaterias.Enabled = false;
            TxtNombre.Enabled = false;
            TxtTitulo.Enabled = false;
            //traerTodo();
        }
        //private void traerTodo()
        //{
        //    DataTable carrerasHab = oBD.consultarCarreras(true);
        //    DataTable carrerasDes = oBD.consultarCarreras(false);
        //}

        private void cargarLista()
        {
            lCarreras.Clear();
            LstCarreras.Items.Clear();
            bool activos;
            if (RbtHabilitadas.Checked)
            {
                activos = true;
            }
            else
            {
                activos = false;
            }
            DataTable dt = oBD.consultarCarreras(activos);
            foreach (DataRow fila in dt.Rows)
            {
                Carrera c = new Carrera();
                c.IdCarrera = Convert.ToInt32(fila[0]);
                c.NombreCarrrera = fila[1].ToString();
                c.Titulo = fila[2].ToString();
                lCarreras.Add(c);
                LstCarreras.Items.Add(c.ToString());
            }
            LstCarreras.SelectedValue = null;
        }

        private void cargarDtg(int selectedIndex)
        {
            DtgDetalles.Rows.Clear();
            DataTable dt = oBD.consultarDetalles(lCarreras[selectedIndex].IdCarrera);
            lCarreras[selectedIndex].Detalles.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                DetalleCarrera d = new DetalleCarrera();
                DataTable tabla = oBD.consutarAsignaturas(Convert.ToInt32(dr[2]));
                foreach(DataRow dr2 in tabla.Rows)
                {
                    Asignatura a = new Asignatura();
                    a.idAsignatura = Convert.ToInt32(dr2[0]);
                    a.Nombre = Convert.ToString(dr2[1]);
                    d.Asignatura = a;
                }
                d.AñoCursado = Convert.ToInt32(dr[3]);
                d.Cuatrimestre = Convert.ToInt32(dr[4]);
                lCarreras[selectedIndex].AgregarDetalle(d);
            }
            int idDetalle = 1;
            foreach (DetalleCarrera detalle in lCarreras[selectedIndex].Detalles)
            {
                DtgDetalles.Rows.Add(new object[] {idDetalle, detalle.Asignatura.ToString(), detalle.AñoCursado, detalle.Cuatrimestre});
                idDetalle++;
            }
        }

        private void cargarCampos(int selectedIndex)
        {
            TxtNombre.Text = lCarreras[selectedIndex].NombreCarrrera;
            TxtTitulo.Text = lCarreras[selectedIndex].Titulo;
            if (RbtHabilitadas.Checked)
            {
                TxtEstado.Text = "Activo";
            }
            else
            {
                TxtEstado.Text = "Inactivo";
            }
            TxtMaterias.Text = Convert.ToString(DtgDetalles.Rows.Count);
        }

        private void LstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDtg(LstCarreras.SelectedIndex);
            cargarCampos(LstCarreras.SelectedIndex);
        }

        private void RbtDeshabilitadas_CheckedChanged(object sender, EventArgs e)
        {
            cargarLista();
            if (RbtDeshabilitadas.Checked)
            {
                BtnHabilitar.Enabled = true;
                BtnDeshabilitar.Enabled = false;
            }
            else
            {
                BtnHabilitar.Enabled = false;
                BtnDeshabilitar.Enabled = true;
            }
        }

        private void BtnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea deshabilitar la carrera?",
                "PRECAUCION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            {
                if (oBD.deshabilitarCarrera(lCarreras[LstCarreras.SelectedIndex].IdCarrera))
                {
                    MessageBox.Show("Se deshabilitó la carrera");
                }
                else
                {
                    MessageBox.Show("Fallo al deshabilitar la carrera");
                }
            }
            cargarLista();
        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea habilitar la carrera?",
                "ACTIVACION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            {
                if (oBD.habilitarCarrera(lCarreras[LstCarreras.SelectedIndex].IdCarrera))
                {
                    MessageBox.Show("Se habilitó la carrera");
                }
                else
                {
                    MessageBox.Show("Fallo al habilitar la carrera");
                }
            }
            cargarLista();
        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
