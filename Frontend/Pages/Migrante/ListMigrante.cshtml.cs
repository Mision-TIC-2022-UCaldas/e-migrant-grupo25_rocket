using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Namespace
{
    //[Authorize]
    public class ListMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repo;
        public IEnumerable<Migrante> Migrantes { get; set;}
        public ListMigranteModel(IRepositorioMigrante repositorioMigrante)
        {
            _repo = repositorioMigrante;
        }        
        public void OnGet()        
        {
            Migrantes = _repo.GetAllMigrante();
        }
        public void OnPost(int id)
        {
            _repo.DeleteMigrante(id);
        }
    }
}
