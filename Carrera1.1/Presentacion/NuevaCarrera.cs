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
    public partial class NuevaCarrera : Form
    {
        Carrera carrera;
        public NuevaCarrera()
        {
            InitializeComponent();
            carrera = Carrera.Instancia();
        }

        private void NuevaCarrera_Load(object sender, EventArgs e)
        {
            cargarCombo();
            LblProximoId.Text = carrera.CargarProximoId();
        }

        private void cargarCombo()
        {
            Asignatura a = Asignatura.Instancia();
            CboAsignaturas.DataSource = a.Read();
            CboAsignaturas.ValueMember = "IdAsignatura";
            CboAsignaturas.DisplayMember = "nomAsignatura";
            CboAsignaturas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //private void cargarDtg()
        //{
        //    DataTable dt = new DataTable();
        //    dt = oBD.consultarDetalles(this.Id);
        //    DtgDetalles.AutoGenerateColumns = false;
        //    foreach (DataRow fila in dt.Rows)
        //    {
        //        DetalleCarrera d = new DetalleCarrera();
        //        d.AñoCursado = Convert.ToInt32(TbAño);
        //        d.Cuatrimestre = Convert.ToInt32(TbCuatri);
        //        d.IdAsignatura = Convert.ToInt32(CboAsignaturas.SelectedValue);
        //        Detalles.Add(d);
        //        DtgDetalles.Rows.Add(lAsignaturas[d.IdAsignatura].Nombre, d.AñoCursado, d.Cuatrimestre);
        //    }
        //}

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            //if (validar())
            //{
            //    if (!existe())
            //    {
            //        DetalleCarrera d = new DetalleCarrera();
            //        d.AñoCursado = Convert.ToInt32(TbAño.Text);
            //        d.Cuatrimestre = Convert.ToInt32(TbCuatri.Text);
            //        d.IdAsignatura = Convert.ToInt32(CboAsignaturas.SelectedValue);
            //        Detalles.Add(d);
            //        cargarDtg();
            //    }
            //    else
            //    {
            //        MessageBox.Show("La materia ya esta en el plan!");
            //    }
            //}

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
            int año = Convert.ToInt32(TbAño.Text);
            int cuatrimestre = Convert.ToInt32(TbCuatri.Text);

            DetalleCarrera detalle = new DetalleCarrera(año, cuatrimestre, a);
            carrera.AgregarDetalle(detalle);
            DtgDetalles.Rows.Add(new object[] {item.Row.ItemArray[0], item.Row.ItemArray[1], TbAño.Text, TbCuatri.Text});
        }

        //private bool existe()
        //{
        //    foreach (DetalleCarrera detalle in carrera.Detalles)
        //    {
        //        if (detalle.Asignatura.Nombre == CboAsignaturas.Text)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        private bool validar()
        {
            if (CboAsignaturas.Text.Equals(String.Empty))
            {
                MessageBox.Show("Ingrese una asignatura");
                return false;
            }
            if (TbAño.Text == "")
            {
                MessageBox.Show("Debe ingresar un año");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TbAño.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico");
                    return false;
                }
            }
            if (TbCuatri.Text == "")
            {
                MessageBox.Show("Ingrese una Cuatrimestre");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TbCuatri.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico");
                    return false;
                }
            }
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.carrera = null;
            Close();
        }

        //private void BtnGuardar_Click(object sender, EventArgs e)
        //{

        //}

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar definitivamente esta carrera?"
                , "GUARDANDO"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                carrera.NombreCarrrera = TbNombreC.Text;
                carrera.Titulo = TbTitulo.Text;
                DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
                if (dao.Insert(carrera)==true)
                {
                    MessageBox.Show("Se creó la carrera con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la carrera", "Error");
                }
            }
        }

        private void DtgDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgDetalles.CurrentCell.ColumnIndex == 4)
            {
                carrera.QuitarDetalle(DtgDetalles.CurrentRow.Index);
                DtgDetalles.Rows.Remove(DtgDetalles.CurrentRow);
            }
        }
    }
}
