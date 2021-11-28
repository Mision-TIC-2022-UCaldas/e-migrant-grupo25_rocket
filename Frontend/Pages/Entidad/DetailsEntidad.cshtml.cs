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
    public class DetailsEntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repo;
        public Entidad entidad { get; set;}
    
        public DetailsEntidadModel(IRepositorioEntidad repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            entidad = _repo.GetEntidad(id);
        }
    }
}
