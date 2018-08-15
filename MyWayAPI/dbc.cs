using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyWayAPI.Models;
using System.Data.Entity.Infrastructure;

namespace MyWayAPI
{
    public class DBC : DbContext
    {
        public DBC()
            : base("Name=DataConnection")
        {
            Configuration.LazyLoadingEnabled = false;

            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = 380;
        }
        public DbSet<ACC011AZ1> Member { get; set; }

        public DbSet<ACC0118K> Area { get; set; }
        public DbSet<ACC011AP> APM { get; set; }
        public DbSet<ACC011AQ> AQD { get; set; }
        public DbSet<ACC011AA> AAD { get; set; }
        public DbSet<ACC011A9> A9M { get; set; }
        public DbSet<liveStock> Stock { get; set; }
        public DbSet<ACC011A3> Products { get; set; }
        public DbSet<A000032C> Periods { get; set; }
    }
}