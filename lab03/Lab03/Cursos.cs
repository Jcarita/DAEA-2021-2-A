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
    public partial class Cursos : Form
    {
        SqlConnection conn;
        public Cursos(SqlConnection conn)
        {
        this.conn = conn;
            InitializeComponent();
        }

        private void btnListarCursos_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {

                String sqlCurso = "SELECT * FROM Course";
                SqlCommand cmd = new SqlCommand(sqlCurso, conn);
                SqlDataReader readerCurso = cmd.ExecuteReader();

                DataTable dtCurso = new DataTable();
                dtCurso.Load(readerCurso);
                dgvTableCursos.DataSource = dtCurso;
                dgvTableCursos.Refresh();
            }
            else
            {
                MessageBox.Show("La conexcion esta cerrada");
            }
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String title = txtCursoTitle.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarCursoTitle";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@title";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = title;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvTableCursos.DataSource = dt;
                dgvTableCursos.Refresh();
            }
            else 
            {
                MessageBox.Show("La conexcion esta cerrada");
            }
        }
    }
}
