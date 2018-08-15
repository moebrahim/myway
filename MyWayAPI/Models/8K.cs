namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class _8K : DbContext
    {
        public _8K()
            : base("name=area8k")
        {
        }

        public virtual DbSet<ACC0118K> ACC0118K { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.AREA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.LSHORT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.ASHORT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.ANAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.DETAILED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC0118K>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);
        }
    }
}
