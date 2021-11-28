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
    public class ListEntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repo;
        public IEnumerable<Entidad> Entidades { get; set;}
        public ListEntidadModel(IRepositorioEntidad repositorioEntidad)
        {
            _repo = repositorioEntidad;
        }        
        public void OnGet()        
        {
            Entidades = _repo.GetAllEntidad();
        }
        public void OnPost(int id)
        {
            _repo.DeleteEntidad(id);
        }
    }
}
