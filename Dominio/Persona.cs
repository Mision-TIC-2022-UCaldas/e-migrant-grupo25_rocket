using System.Xml.Schema;
using System;
using System.ComponentModel.DataAnnotations;
namespace Dominio
{
    public class Persona
    {
        [Required]        
        public int Id {get; set; }        
        [Required(ErrorMessage="Por favor ingresa tu nombre"),MaxLength(30)]        
        public string Nombre {get; set; }
        [Required(ErrorMessage="Por favor ingresa tus apellidos"),MaxLength(30)]        
        public string Apellidos {get; set; }
        [Required(ErrorMessage="Por favor ingresa el tipo de documento de identificacion")]        
        public int TipoDocumento {get; set; }
        [Required(ErrorMessage="Por favor ingresa el numero documento de identificacion"),MaxLength(30)]        
        public string Documento {get; set; }
        [Required(ErrorMessage="Por favor ingresa tu pais de "),MaxLength(30)]        
        public string Pais {get; set; }
        [Required(ErrorMessage="Por favor ingresa tu fecha de nacimiento"),MaxLength(10)]        
        public string FechaNacimiento {get; set; }        
    }
}