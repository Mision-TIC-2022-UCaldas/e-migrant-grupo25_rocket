using Dominio;
using System.Collections.Generic;
using System.Linq; 
namespace Persistencia
{
    public interface IRepositorioEntidad
    {
        IEnumerable<Entidad> GetAllEntidad();
        Entidad AddEntidad(Entidad entidad);
        Entidad UpdateEntidad(Entidad entidad);
        void DeleteEntidad(int IdEntidad);
        Entidad GetEntidad(int IdEntidad);         
    }
}