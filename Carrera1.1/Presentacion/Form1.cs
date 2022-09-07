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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCarrera form = new NuevaCarrera();
            form.ShowDialog();
            form.Dispose();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCarreras form = new FrmConsultarCarreras();
            form.ShowDialog();
            form.Dispose();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.FrmModificarDetalles form = new Presentacion.FrmModificarDetalles();
            form.ShowDialog();
            form.Dispose();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.ABMAsignaturas form = new Presentacion.ABMAsignaturas();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
