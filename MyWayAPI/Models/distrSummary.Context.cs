﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities5 : DbContext
    {
        public Entities5()
            : base("name=Entities5")
        {
            Configuration.LazyLoadingEnabled = false;

            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = 380;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<distr_summary_Result> distr_summary(string distr)
        {
            var distrParameter = distr != null ?
                new ObjectParameter("distr", distr) :
                new ObjectParameter("distr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<distr_summary_Result>("distr_summary", distrParameter);
        }
    }
}
