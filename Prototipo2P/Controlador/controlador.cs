﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Data.Odbc;
using System.Data;

namespace Controlador
{
    public class controlador
    {
        sentencias sn = new sentencias();

        public void ingresar(TextBox[] textbox, string tabla)
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
        }

        public void actualizar(TextBox[] textbox, string tabla, string campo, int num)
        {
            string dato = " ";
            string condicion = campo;

            for (int x = 1; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "' ";

                }
                else if (x == 1)
                {
                    dato += "SET " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }
                else
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }

            }

            sn.actualizar(dato, condicion, tabla, num);
            MessageBox.Show("Dato actualizado");
        }

        public void eliminar(string tabla, string condicion, int campo)
        {
            try
            {
                sn.eliminar(tabla, condicion, campo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se elimino");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }


        }


        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenartabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }



    }
}
