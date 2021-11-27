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
    public class CreateMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repo;
        public Migrante migrante { get; set;}
        
        public CreateMigranteModel(IRepositorioMigrante repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
        }
        public void OnPost(Migrante migrante)
        {   
                _repo.AddMigrante(migrante);            
        }
        public void Prueba()
        {
            Console.WriteLine(migrante.Nombre);
        }
    }
}
