using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Negocio
{
    public class clsNegPerson
    {
        clsDAOPerson daoPerson = new clsDAOPerson();

        public DataTable GetAll()
        {
            return daoPerson.GetAll();
        }
        
        public DataTable GetByValue(string name)
        {
            return daoPerson.GetByValue(name);
        }
        public bool savePerson
            (String firstName, String lastName, 
            String hireDate, String enrollmentDate)
        {
            bool person = daoPerson.newPerson(firstName, lastName, hireDate, enrollmentDate);
            if (person)
                return true;
            else
                return false;
        }
    }
}
