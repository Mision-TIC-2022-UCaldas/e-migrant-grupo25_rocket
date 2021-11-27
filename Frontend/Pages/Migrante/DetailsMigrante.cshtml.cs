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
    public class DetailsMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repo;
        public Migrante migrante { get; set;}
    
        public DetailsMigranteModel(IRepositorioMigrante repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            migrante = _repo.GetMigrante(id);
        }
    }
}
