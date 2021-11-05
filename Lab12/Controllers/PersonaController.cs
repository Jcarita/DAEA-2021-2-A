using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;
    
namespace Lab12.Controllers
{
    public class PersonaController : Controller
    {
        List<Persona> personas = new List<Persona>();
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            personas.Add(new Persona
            { 
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "AV. Evergreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "AV. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "AV. Los manzanos 101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@gmail.com"
            });
            return View(personas);
        }
    }
}