using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRUEBA.Models
{
    public class AlumnosDatos
    {
      [Key]

        public int Id { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}