using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asignarBodegaproductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bodegas b = new bodegas();
            b.MdiParent = this;
            b.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marcas b = new marcas();
            b.MdiParent = this;
            b.Show();
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineas b = new lineas();
            b.MdiParent = this;
            b.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos b = new productos();
            b.MdiParent = this;
            b.Show();
        }

        private void asignarBodegaAProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            existencias b = new existencias();
            b.MdiParent = this;
            b.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas b = new consultas();
            b.MdiParent = this;
            b.Show();
        }
    }
}
