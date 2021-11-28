using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;


namespace MyApp.Namespace
{
    public class DeleteMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repo;
        public Migrante migrante { get; set;}

        public DeleteMigranteModel(IRepositorioMigrante repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteMigrante(id);
        }
    }
}

