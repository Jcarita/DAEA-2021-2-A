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

namespace Lab06
{
    public partial class ManPerson : Form
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public ManPerson()
        {
            InitializeComponent();
        }

        private void ManPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-M0H5GAK;DataBase=School;Integrated Security=true;";
            conn = new SqlConnection(str);
            statusDgv();
        }
        public void statusDgv()
        {
        if(dgvListado.Rows.Count == 0)
            {
                btnBcCodigo.Enabled = false;
                btnOrLastName.Enabled = false;
            }
            else
            {
                btnBcCodigo.Enabled = true;
                btnOrLastName.Enabled = true;
            }
        }
        public void clearData()
        {
            txtPersonId.Text = "";
            txtPersonId.Enabled = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHireDate.Value = DateTime.Now;
            txtEnrollmentDate.Value = DateTime.Now;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];
            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
            conn.Close();
            statusDgv();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertPerson", conn);
            
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtFirstName.Text;
            fila["HireDate"] = txtHireDate.Text;
            fila["EnrollmentDate"] = txtEnrollmentDate.Text;
            tablePerson.Rows.Add(fila);
            adapter.Update(tablePerson);

            //int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            //MessageBox.Show("Se ha registrado nueva persona con el codigo: "+ codigo);
            conn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UpdatePerson", conn);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '"+ Convert.ToInt32(txtPersonId.Text) + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["HireDate"] = txtHireDate.Text;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;

            adapter.Update(tablePerson);

            /*int resultado = cmd.ExecuteNonQuery();
            if(resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }*/
            conn.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if( dgvListado.SelectedRows.Count > 0)
            {
                txtPersonId.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                string hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hireDate))
                    txtHireDate.Checked = false;
                else
                    txtHireDate.Text = hireDate;

                string enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();

                if (String.IsNullOrEmpty(enrollmentDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = enrollmentDate;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DeletePerson", conn);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '"+ Convert.ToInt32(txtPersonId.Text) + "'");
            tablePerson.Rows.Remove(fila[0]);
            adapter.Update(tablePerson);

            clearData();
            /*int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Se elimnino correctamente");
            }*/
            conn.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtPersonId.Text.Length > 0)
            {
                String sql = "SELECT * FROM Person WHERE PersonID =" + txtPersonId.Text + "";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();

                MessageBox.Show("Hay texto en Person ID");
            }
            else if (txtFirstName.Text.Length > 0)
            {
                String sql = "SELECT * FROM Person  WHERE FirstName LIKE '%"+txtFirstName.Text+"%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
                MessageBox.Show("Hay textp em FirstName");
            }
            else if (txtLastName.Text.Length > 0)
            {
                String sql = "SELECT * FROM Person  WHERE LastName LIKE '%" + txtLastName.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
                MessageBox.Show("Lastename");
            }
            conn.Close();
        }

        private void btnOrLastName_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.Sort = "LastName ASC";
            dgvListado.DataSource = dv;
        }

        private void btnBcCodigo_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "PersonID = '" + Convert.ToInt32(txtPersonId.Text)+"'";
            dgvListado.DataSource = dv;
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            statusDgv();
            clearData();
        }
    }
}
