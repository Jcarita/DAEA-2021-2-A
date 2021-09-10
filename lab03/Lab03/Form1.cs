using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
                
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            String servidor = txtServidor.Text;
            String database = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String password = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" + database + ";";

            if (chkAuthentication.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + password + ";";

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado Exitosamente");
                btnDesconectar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State + "" +
                        "\nVersion del servidor: " + conn.ServerVersion +
                        "\nBase de Datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del servidor: "+ conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible  determinar el estado del servidor: \n" +
                            ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexcion cerrada exitosamente");
                }
                else
                    MessageBox.Show("La conexcion ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar cerrar la coneccion: \n"+
                    ex.ToString());
            }
        }

        private void chkAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuthentication.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else 
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos(conn);
            curso.Show();
        }
    }
}
