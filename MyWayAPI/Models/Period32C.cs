namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Period32C : DbContext
    {
        public Period32C()
            : base("name=Period32C")
        {
        }

        public virtual DbSet<A000032C> A000032C { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A000032C>()
                .Property(e => e.MODULE_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.COMP_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.TON_SSAP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.DATA_DB)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.DATA_DRVR)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.DATA_SRVR)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.DATA_USER)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.DATA_PASS)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.TITLE_ATTR)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.CAP_ATTR)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.EDIT_FONT)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.EDIT_3D)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.EDIT_SHADE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.R_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.R_CAPFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.R_T_HDRFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.R_G_HDRFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.R_COLFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.R_FOOTFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.G_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.G_HDRFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.G_FOOTFNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.YEAR_START)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.CNSLD_COMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.SYS_PREFIX)
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.CLOSE_DATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A000032C>()
                .Property(e => e.ACTV_KEY)
                .IsUnicode(false);
        }
    }
}
