using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera1._1.Presentacion
{
    public partial class FrmModificarDetalles : Form
    {
        List<Carrera> lCarreras;
        List<Asignatura> lAsignaturas;
        DBHelper oBD;
        public FrmModificarDetalles()
        {
            InitializeComponent();
            lCarreras = new List<Carrera>();
            lAsignaturas = new List<Asignatura>();
            oBD = new DBHelper();
        }

        private void FrmModificarDetalles_Load(object sender, EventArgs e)
        {
            cargarLista();
            cargarComboAsignaturas();
            TxtNombre.Enabled = false;
            TxtTitulo.Enabled = false;
            Detalles.Enabled = false;
            BtnEditar.Enabled = false;
        }

        private void cargarComboAsignaturas()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consutarAsignaturas();
            CboAsignaturas.DataSource = tabla;
            CboAsignaturas.DisplayMember = "nomAsignatura";
            CboAsignaturas.ValueMember = "idAsignatura";
            CboAsignaturas.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DataRow dr in tabla.Rows)
            {
                Asignatura a = new Asignatura();
                a.idAsignatura = Convert.ToInt32(dr[0]);
                a.Nombre = Convert.ToString(dr[1]);
                lAsignaturas.Add(a);
            }
        }

        private void cargarDtg(int selectedIndex)
        {
            DtgDetalles.Rows.Clear();
            DataTable dt = oBD.consultarDetalles(lCarreras[selectedIndex].IdCarrera);
            lCarreras[selectedIndex].Detalles.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DetalleCarrera d = new DetalleCarrera();
                DataTable tabla = oBD.consutarAsignaturas(Convert.ToInt32(dr[2]));
                foreach (DataRow dr2 in tabla.Rows)
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
                DtgDetalles.Rows.Add(new object[] { idDetalle, detalle.Asignatura.ToString(), detalle.AñoCursado, detalle.Cuatrimestre });
                idDetalle++;
            }
        }

        private void cargarLista()
        {
            lCarreras.Clear();
            LstCarreras.Items.Clear();
            DataTable dt = oBD.consultarCarreras(true);
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

        private void LstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDtg(LstCarreras.SelectedIndex);
            cargarCampos(LstCarreras.SelectedIndex);
        }
        private void cargarCampos(int selectedIndex)
        {
            TxtNombre.Text = lCarreras[selectedIndex].NombreCarrrera;
            TxtTitulo.Text = lCarreras[selectedIndex].Titulo;
            BtnEditar.Enabled = true;
        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            foreach (DataGridViewRow row in DtgDetalles.Rows)
            {
                if (row.Cells["colAsignatura"].Value.ToString().Equals(CboAsignaturas.Text))
                {
                    MessageBox.Show("Asignatura: " + CboAsignaturas.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DataRowView item = (DataRowView)CboAsignaturas.SelectedItem;

            int idAsignautura = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            Asignatura a = new Asignatura(nom, idAsignautura);
            int año = Convert.ToInt32(TxtAño.Text);
            int cuatrimestre = Convert.ToInt32(TxtCuatri.Text);

            DetalleCarrera detalle = new DetalleCarrera(año, cuatrimestre, a);
            lCarreras[LstCarreras.SelectedIndex].AgregarDetalle(detalle);
            DtgDetalles.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], TxtAño.Text, TxtCuatri.Text });
        }

        private bool validar()
        {
            if (CboAsignaturas.Text.Equals(String.Empty))
            {
                MessageBox.Show("Ingrese una asignatura");
                return false;
            }
            if (TxtAño.Text == "")
            {
                MessageBox.Show("Debe ingresar un año");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TxtAño.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico");
                    return false;
                }
            }
            if (TxtCuatri.Text == "")
            {
                MessageBox.Show("Ingrese una Cuatrimestre");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TxtCuatri.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico");
                    return false;
                }
            }
            return true;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea modificar definitivamente esta carrera?"
                , "GUARDANDO"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (oBD.modificarDetalle(lCarreras[LstCarreras.SelectedIndex]) == true)
                {
                    MessageBox.Show("Se modificó la carrera con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la carrera", "Error");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            LstCarreras.Enabled = false;
            Detalles.Enabled = true;
        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
