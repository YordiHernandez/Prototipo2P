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
    public partial class marcas : Form
    {
        public marcas()
        {
            InitializeComponent();
        }

        controlador cn = new controlador();
        string table = "tbl_marcas";

        public void llenar()
        {
            DataTable dt = cn.llenarTbl(table);
            Dt1.DataSource = dt;
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                TxtEstado.Text = "1";
            }

            if (checkBox2.Checked)
            {
                TxtEstado.Text = "0";
            }
        }

        public void limpiar()
        {
            TxtCodigo.Text = "";
            TxtEstado.Text = "";
            TxtME.Text = "";
            TxtNombre.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }





        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            checkbox();
            if (TxtCodigo.Text == "" || TxtEstado.Text == "" || TxtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {

                TextBox[] textbox = { TxtCodigo, TxtEstado, TxtNombre };
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                limpiar();
                llenar();
                MessageBox.Show(message);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            checkbox();
            if (TxtCodigo.Text == "" || TxtEstado.Text == "" || TxtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");

            }
            else
            {

                checkbox();
                TextBox[] textbox = { TxtCodigo, TxtEstado, TxtNombre };
                int valor1 = int.Parse(TxtME.Text);
                string campo = "pk_codigo_marca = ";
                cn.actualizar(textbox, table, campo, valor1);
                MessageBox.Show("Dato modificado");
                limpiar();
                llenar();

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(TxtME.Text);
                string condicion = "pk_codigo_marca = ";
                cn.eliminar(table, condicion, campo);
                limpiar();
                llenar();
                MessageBox.Show("Registro Eliminado");

            }
            else
            {
                limpiar();
                llenar();

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void marcas_Load(object sender, EventArgs e)
        {
            llenar();
        }
    }
}
