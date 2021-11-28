using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositorioServicio : IRepositorioServicio
    {
        private readonly AplicationContext _appContext;

        public RepositorioServicio(AplicationContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Servicio AddServicio(Servicio servicio)
        {    
            var new_servicio =_appContext.servicio.Add(servicio);
            _appContext.SaveChanges();
            return new_servicio.Entity;
        }

        public void DeleteServicio(int IdServicio)
        {
            Servicio servicio_encontrado = _appContext.servicio.FirstOrDefault(
                p => p.Id == IdServicio);
            if(servicio_encontrado != null)
            {                          
                _appContext.Remove(servicio_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Servicio> GetAllServicio()
        {
            return _appContext.servicio;            
        }

        public Servicio UpdateServicio(Servicio servicio)
        {
            Servicio servicio_encontrado = _appContext.servicio.FirstOrDefault(
                p => p.Id == servicio.Id);
            if(servicio_encontrado != null)
            {
                servicio_encontrado.IdEntidad = servicio.IdEntidad;
                servicio_encontrado.Nombre = servicio.Nombre;
                servicio_encontrado.NumeroMigrantes = servicio.NumeroMigrantes;
                servicio_encontrado.FechaInicio = servicio.FechaInicio;
                servicio_encontrado.FechaFin = servicio.FechaFin; 
                servicio_encontrado.Estado = servicio.Estado;
                
                
                _appContext.Update(servicio_encontrado);
                _appContext.SaveChanges();  
                return servicio_encontrado;
            }        
            return null;            
        }

        public Servicio GetServicio(int IdServicio)
        {
            return _appContext.servicio.FirstOrDefault(
                p => p.Id == IdServicio);
        }

        Servicio IRepositorioServicio.AddServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }

        Servicio IRepositorioServicio.UpdateServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }
    }
}