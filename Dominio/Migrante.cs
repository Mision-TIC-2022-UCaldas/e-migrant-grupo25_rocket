using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Migrante : Persona
    {
        [StringLength(30,ErrorMessage="Correo muy largo")]
        public string Correo {get; set; }
        [StringLength(30,ErrorMessage="Telefono muy largo")]
        public string Telefono {get; set; }
        [StringLength(40,ErrorMessage="Direccion muy larga")]
        public string Direccion {get; set; }
        [StringLength(30,ErrorMessage="Ciudad muy larga")]
        public string Ciudad {get; set; }
        [StringLength(30,ErrorMessage="Situacion laboral desconocida muy larga")]
        public string SituacionLaboral {get; set; }
    }
}