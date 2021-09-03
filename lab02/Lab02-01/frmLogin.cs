using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
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
            string [] credentials = new string[2] {"usuario","password" };

            if (credentials[0] == txtUsuario.Text && credentials[1] == txtPassword.Text) 
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else 
            {
                lblErrorCredential.Visible = true;
            }
            
        }
    }
}
