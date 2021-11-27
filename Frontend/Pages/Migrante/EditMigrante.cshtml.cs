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
    public class EditMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repo;
        public Migrante migrante { get; set;}
        public EditMigranteModel(IRepositorioMigrante repo)
        {
            _repo = repo;
        }
         public void OnPost(Migrante migrante)
        {             
            _repo.UpdateMigrante(migrante);
        }
        public void OnGet(int id)
        {
            migrante = _repo.GetMigrante(id);
        }
    }
}
