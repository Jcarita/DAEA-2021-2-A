using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab13.Models
{
    public class Persona
    {
        public int PersonaID { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es requerido")]
        public string Apellido { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "El campo es tipo fecha")]
        public DateTime FechaNac { get; set; }
        [Required(ErrorMessage = "El campo Direccion es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo Email es requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email incorrecto")]
        public string Email { get; set; }

    }
}