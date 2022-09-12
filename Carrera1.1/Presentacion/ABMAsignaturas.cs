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
        public ABMAsignaturas()
        {
            InitializeComponent();
            lAsignaturas = new List<Asignatura>();
        }

        private void ABMAsignaturas_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            LstAsignaturas.Items.Clear();
            DaoMaestroDetalle dao = DaoMaestroDetalle.Instancia();
            DataTable tabla = dao.consutarAsignaturas();
            foreach (DataRow dr in tabla.Rows)
            {
                Asignatura a = new Asignatura(Convert.ToString(dr[1]), Convert.ToInt32(dr[0]));
                lAsignaturas.Add(a);
                LstAsignaturas.Items.Add(a.ToString());
            }
        }

        
    }
}
