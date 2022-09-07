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
    public partial class ABMAsignaturas : Form
    {
        List<Asignatura> lAsignaturas;
        DBHelper oBD;
        public ABMAsignaturas()
        {
            InitializeComponent();
            lAsignaturas = new List<Asignatura>();
            oBD = new DBHelper();
        }

        private void ABMAsignaturas_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            LstAsignaturas.Items.Clear();
            DataTable tabla = oBD.consutarAsignaturas();
            foreach (DataRow dr in tabla.Rows)
            {
                Asignatura a = new Asignatura();
                a.idAsignatura = Convert.ToInt32(dr[0]);
                a.Nombre = Convert.ToString(dr[1]);
                lAsignaturas.Add(a);
                LstAsignaturas.Items.Add(a.ToString());
            }
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            AltaAsignatura form = new AltaAsignatura();
            form.ShowDialog();
            form.Dispose();
            cargarLista();
        }
    }
}
