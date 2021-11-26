using Dominio;
using System.Collections.Generic;
using System.Linq; 
namespace Persistencia
{
    public interface IRepositorioMigrante
    {
        IEnumerable<Migrante> GetAllMigrante();
        Migrante AddMigrante(Migrante migrante);
        Migrante UpdateMigrante(Migrante migrante);
        void DeleteMigrante(int IdMigrante);
        Migrante GetMigrante(int IdMigrante);         
    }
}