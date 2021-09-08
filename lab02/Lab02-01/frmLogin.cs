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

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        String userSql, passSql;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-M0H5GAK;Database=db_lab03;User Id=sa;Password=servidorx;";
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                String sql = "SELECT usuario_nombre, usuario_password FROM tbl_usuario \n" +
                             "WHERE usuario_nombre = '"+txtUsuario.Text+"' AND usuario_password = '"+txtPassword.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userSql = reader[0].ToString();
                    passSql = reader[1].ToString();
                }
               
                if (txtUsuario.Text == userSql  &&  txtPassword.Text == passSql)
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    lblErrorCredential.Visible = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexcion"+ex.ToString());
            }

        }
    }
}
