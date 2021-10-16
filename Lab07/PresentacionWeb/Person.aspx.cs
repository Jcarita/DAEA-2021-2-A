using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace PresentacionWeb
{
    public partial class Person : System.Web.UI.Page
    {
        protected void refreshData()
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgvDatos.DataSource = dt;
            dgvDatos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsNegPerson np = new clsNegPerson();
            bool resp = np.savePerson(txtFirstName.Text,txtLastName.Text,
                txtHireDate.Text,txtEnrollmentDate.Text);
            if (resp)
                refreshData();
            else
                Response.Write("<script>alert('Hubo un problema al guardar');</script>");


        }
    }
}