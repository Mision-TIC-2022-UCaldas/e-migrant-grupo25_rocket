using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
     public class CreateEntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repo;
        public Entidad entidad { get; set;}
        
        
        public CreateEntidadModel(IRepositorioEntidad repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
        }
        public void OnPost(Entidad entidad)
        {   
                _repo.AddEntidad(entidad);            
        }
        public void Prueba()
        {
            Console.WriteLine(entidad.RazonSocial);
        }
    }
}
