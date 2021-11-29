using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
namespace MyApp.Namespace
{
    public class SearchMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repo;
        public Migrante migrante { get; set;}
        public IEnumerable<Migrante> Migrantes { get; set;}
        
        [BindProperty(SupportsGet = true)]
        public string SearchTerm {get; set;}
    
        public SearchMigranteModel(IRepositorioMigrante repo)
        {
            _repo = repo;
        }        

        public void OnGet()
        {
            Migrantes = _repo.GetAllMigrante();

            migrante = _repo.GetMigranteDoc(SearchTerm);
            Console.WriteLine(SearchTerm); 
        }
        public void OnPost(string MigDocumento)
        {
            try{
                migrante = _repo.GetMigranteDoc(MigDocumento);
                Console.WriteLine(migrante.Nombre);               
            }
            catch{

            }
        }       
    }
}