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
    
    public partial class CLOUD_COORDINATOREntities1 : DbContext
    {
        public CLOUD_COORDINATOREntities1()
            : base("name=CLOUD_COORDINATOREntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<string> EditVou(string dOCID, string dISTRID)
        {
            var dOCIDParameter = dOCID != null ?
                new ObjectParameter("DOCID", dOCID) :
                new ObjectParameter("DOCID", typeof(string));
    
            var dISTRIDParameter = dISTRID != null ?
                new ObjectParameter("DISTRID", dISTRID) :
                new ObjectParameter("DISTRID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EditVou", dOCIDParameter, dISTRIDParameter);
        }
    }
}
