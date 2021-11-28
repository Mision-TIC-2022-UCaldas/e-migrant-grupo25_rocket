using Dominio;
using System.Collections.Generic;
using System.Linq; 
namespace Persistencia
{
    public interface IRepositorioServicio
    {
        IEnumerable<Servicio> GetAllServicio();
        Servicio AddServicio(Servicio servicio);
        Servicio UpdateServicio(Servicio servicio);
        void DeleteServicio(int IdServicio);
        Servicio GetServicio(int IdServicio);         
    }
}