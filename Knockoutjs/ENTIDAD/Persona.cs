using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ENTIDAD
{
    public class Persona {

        [DisplayFormat(NullDisplayText = "Sin Respuesta")]
        [Display(Name = "Código Persona")]
        [Key]
        public int id { get; set; }

        [DisplayFormat(NullDisplayText = "Sin Respuesta")]
        [Display(Name = "Nombre")]
        
        public string nombre { get; set; }

        [DisplayFormat(NullDisplayText = "Sin Respuesta")]
        [Display(Name = "Primer Apellido")]

        public string apellido { get; set; }


        [DisplayFormat(NullDisplayText = "Sin Respuesta")]
        [Display(Name = "Correo")]

        public string correo { get; set; }

        [DisplayFormat(NullDisplayText = "Sin Respuesta")]
        [Display(Name = "Cedula")]

        public string cedula { get; set; }

        public Persona(int idPersona, string nombre, string apellido, string correo, string cedula)
        {
            this.id = idPersona;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cedula = cedula;
        }
        public Persona( string nombre, string apellido, string correo, string cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cedula = cedula;
        }
        public Persona()
        {
        }
    }
}
