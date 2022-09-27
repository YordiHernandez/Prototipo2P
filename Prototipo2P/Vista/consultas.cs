using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class consultas : Form
    {

        string table ="";

        controlador cn = new controlador();

        public consultas()
        {
            InitializeComponent();
        }

        public void llenarmarcas()
        {
            table = "tbl_marcas";
            DataTable dt = cn.llenarTbl(table);
            Dt1.DataSource = dt;
        }
        public void llenarlineas()
        {
            table = "tbl_lineas";
            DataTable dt = cn.llenarTbl(table);
            Dt1.DataSource = dt;
        }
        public void llenarbodegas()
        {
            table = "tbl_bodegas";
            DataTable dt = cn.llenarTbl(table);
            Dt1.DataSource = dt;
        }
        public void llenarprod()
        {
            table = "tbl_productos";
            DataTable dt = cn.llenarTbl(table);
            Dt1.DataSource = dt;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            llenarmarcas();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarlineas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            llenarbodegas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            llenarprod();
        }
    }
}
