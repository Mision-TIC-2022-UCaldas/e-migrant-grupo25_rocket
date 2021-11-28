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
     public class CreateServiciosModel : PageModel
    {
        private readonly IRepositorioServicio _repo;
        public Servicio servicio { get; set;}
        
        public CreateServiciosModel(IRepositorioServicio repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
        }
        public void OnPost(Servicio servicio)
        {   
                _repo.AddServicio(servicio);            
        }
        public void Prueba()
        {
            Console.WriteLine(servicio.Nombre);
        }
    }
}
