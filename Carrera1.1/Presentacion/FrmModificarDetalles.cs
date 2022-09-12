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
        List<Asignatura> lAsignaturas;
        List<Carrera> lCarreras;
        public FrmModificarDetalles()
        {
            InitializeComponent();
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
            Asignatura a = Asignatura.Instancia();
            lAsignaturas = a.Read();
            CboAsignaturas.DataSource = lAsignaturas;
            CboAsignaturas.ValueMember = "IdAsignatura";
            CboAsignaturas.DisplayMember = "Nombre";
        }



        public void CargarDtg(int selectedIndex)
        {
            DtgDetalles.Rows.Clear();
            int idDetalle = 1;
            foreach (DetalleCarrera detalle in lCarreras[selectedIndex].Detalles)
            {
                DtgDetalles.Rows.Add(new object[] { idDetalle, detalle.Asignatura.ToString(), detalle.AñoCursado, detalle.Cuatrimestre });
                idDetalle++;
            }
        }

        private void cargarLista()
        {
            LstCarreras.Items.Clear();
            Carrera c = Carrera.Instancia();
            lCarreras = c.Read(true);
            foreach (Carrera carrera in lCarreras)
            {
                LstCarreras.Items.Add(carrera.ToString());
            }
        }

        private void LstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDtg(LstCarreras.SelectedIndex);
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
                DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
                if (dao.Update(lCarreras[LstCarreras.SelectedIndex]) == true)
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

        private void DtgDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgDetalles.CurrentCell.ColumnIndex == 4)
            {
                lCarreras[LstCarreras.SelectedIndex].QuitarDetalle(DtgDetalles.CurrentRow.Index);
                DtgDetalles.Rows.Remove(DtgDetalles.CurrentRow);
            }
        }
    }
}
