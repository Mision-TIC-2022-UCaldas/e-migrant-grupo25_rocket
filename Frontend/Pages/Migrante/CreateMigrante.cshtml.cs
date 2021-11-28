using System.Net;
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
        public string Message {get; set;} = "Error";    
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
            try{
                _repo.AddMigrante(migrante);            
            }
            catch{
                Message ="Numero de Documento ya registrado";
                ViewData["Message"]=Message;
                Console.WriteLine(Message);
            }   
                
        }
        public void Prueba()
        {
            Console.WriteLine(migrante.Nombre);
        }
    }
}
