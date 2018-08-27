namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Products : DbContext
    {
        public Products()
            : base("name=Products")
        {
        }

        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ANAME)
                .IsUnicode(false);
        }
    }
}
