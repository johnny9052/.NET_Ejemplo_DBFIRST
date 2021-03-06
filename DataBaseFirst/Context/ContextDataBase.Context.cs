﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseFirst.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EjercicioFrameworkEntities : DbContext
    {
        public EjercicioFrameworkEntities()
            : base("name=EjercicioFrameworkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cantidad> cantidad { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
    
        public virtual int disminuir(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("disminuir", idParameter);
        }
    
        public virtual int guardarMunicipio(string nombre, Nullable<int> idDepartamento)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("idDepartamento", idDepartamento) :
                new ObjectParameter("idDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("guardarMunicipio", nombreParameter, idDepartamentoParameter);
        }
    
        public virtual ObjectResult<listarMunicipios_Result> listarMunicipios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarMunicipios_Result>("listarMunicipios");
        }
    
        public virtual int disminuir1(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("disminuir1", idParameter);
        }
    
        public virtual int guardarMunicipio1(string nombre, Nullable<int> idDepartamento)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("idDepartamento", idDepartamento) :
                new ObjectParameter("idDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("guardarMunicipio1", nombreParameter, idDepartamentoParameter);
        }
    
        public virtual ObjectResult<listarMunicipios1_Result> listarMunicipios1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarMunicipios1_Result>("listarMunicipios1");
        }
    
        public virtual ObjectResult<listarDepartamento_Result> listarDepartamento()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarDepartamento_Result>("listarDepartamento");
        }
    
        public virtual int guardarDepartamento(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("guardarDepartamento", nombreParameter);
        }
    }
}
