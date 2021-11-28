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
    public class EditEntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repo;
        public Entidad entidad { get; set;}
        public EditEntidadModel(IRepositorioEntidad repo)
        {
            _repo = repo;
        }
         public void OnPost(Entidad entidad)
        {             
            _repo.UpdateEntidad(entidad);
        }
        public void OnGet(int id)
        {
            entidad = _repo.GetEntidad(id);
        }
    }
}
