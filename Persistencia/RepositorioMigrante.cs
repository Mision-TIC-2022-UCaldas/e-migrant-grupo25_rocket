using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private readonly AplicationContext _appContext;

        public RepositorioMigrante(AplicationContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Migrante AddMigrante(Migrante migrante)
        {    
            var new_migrante=_appContext.migrante.Add(migrante);
            _appContext.SaveChanges();
            return new_migrante.Entity;
        }

        public void DeleteMigrante(int IdMigrante)
        {
            Migrante migrante_encontrado = _appContext.migrante.FirstOrDefault(
                p => p.Id == IdMigrante);
            if(migrante_encontrado != null)
            {                          
                _appContext.Remove(migrante_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Migrante> GetAllMigrante()
        {
            return _appContext.migrante;            
        }

        public Migrante UpdateMigrante(Migrante migrante)
        {
            Migrante migrante_encontrado = _appContext.migrante.FirstOrDefault(
                p => p.Id == migrante.Id);
            if(migrante_encontrado != null)
            {
                migrante_encontrado.Nombre = migrante.Nombre;
                migrante_encontrado.Apellidos = migrante.Apellidos;
                migrante_encontrado.TipoDocumento = migrante.TipoDocumento;
                migrante_encontrado.Documento = migrante.Documento; 
                migrante_encontrado.Pais = migrante.Pais;
                migrante_encontrado.FechaNacimiento = migrante.FechaNacimiento;
                migrante_encontrado.Direccion = migrante.Direccion;
                migrante_encontrado.Telefono = migrante.Telefono;
                migrante_encontrado.Direccion = migrante.Direccion;
                migrante_encontrado.Ciudad = migrante.Ciudad;
                migrante_encontrado.SituacionLaboral = migrante.SituacionLaboral;
                
                _appContext.Update(migrante_encontrado);
                _appContext.SaveChanges();  
                return migrante_encontrado;
            }        
            return null;            
        }

        public Migrante GetMigrante(int IdMigrante)
        {
            return _appContext.migrante.FirstOrDefault(
                p => p.Id == IdMigrante);
        }
    }
}