using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class clsDAOPerson: clsDAO
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            con.Close();
            return dt;
        }
        public DataTable GetByValue(string value)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "FindPersonByData";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Busqueda";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = value;
            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            con.Close();
            return dt;
        }
        public bool newPerson(String firstName, String lastName, String hireDate,String enrollmentDate)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertPerson",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@HireDate", hireDate);
            cmd.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                return true;
            else
                return false;
            
            con.Close();
        }
    }
}
