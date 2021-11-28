using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {
        private readonly AplicationContext _appContext;

        public RepositorioEntidad(AplicationContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Entidad AddEntidad(Entidad entidad)
        {    
            var new_entidad=_appContext.entidad.Add(entidad);
            _appContext.SaveChanges();
            return new_entidad.Entity;
        }

        public void DeleteEntidad(int IdEntidad)
        {
            Entidad entidad_encontrado = _appContext.entidad.FirstOrDefault(
                p => p.Id == IdEntidad);
            if(entidad_encontrado != null)
            {                          
                _appContext.Remove(entidad_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Entidad> GetAllEntidad()
        {
            return _appContext.entidad;            
        }

        public Entidad UpdateEntidad(Entidad entidad)
        {
            Entidad entidad_encontrado = _appContext.entidad.FirstOrDefault(
                p => p.Id == entidad.Id);
            if(entidad_encontrado != null)
            {
                entidad_encontrado.RazonSocial = entidad.RazonSocial;
                entidad_encontrado.Nit = entidad.Nit;
                entidad_encontrado.Direccion = entidad.Direccion;
                entidad_encontrado.Ciudad = entidad.Ciudad; 
                entidad_encontrado.Telefono = entidad.Telefono;
                entidad_encontrado.Correo = entidad.Correo;
                entidad_encontrado.PaginaWeb = entidad.PaginaWeb;
                entidad_encontrado.Sector = entidad.Sector;
                entidad_encontrado.Servicios = entidad.Servicios;
                
                _appContext.Update(entidad_encontrado);
                _appContext.SaveChanges();  
                return entidad_encontrado;
            }        
            return null;            
        }

        public Entidad GetEntidad(int IdEntidad)
        {
            return _appContext.entidad.FirstOrDefault(
                p => p.Id == IdEntidad);
        }
    }
}