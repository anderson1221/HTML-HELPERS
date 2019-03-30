using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaHelpers.Models
{
    public class TDatos
    {
        [Required (ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
        [Range(15, 100, ErrorMessage = "Se aceptan mayores a 15")]
        public int Edad { get; set; }
        [Phone]
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "Este campo es obligatorio para correos")]
        public string Correo { get; set; }
        public Genero Genero { get; set; }
        public string Estado_Civil { get; set; }
        public List<ControlIds> Hobbys { get; set; }
    }
}
public enum Genero
{
    Masculino,
    Femenino
}