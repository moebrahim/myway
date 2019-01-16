namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DSSP : DbContext
    {
        public DSSP()
            : base("name=DSSP")
        {
        }

        public virtual DbSet<ACC011DSSP> ACC011DSSP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.DS_SHIPMENT_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.ID_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.ANAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.HELD)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.DETAILED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011DSSP>()
                .Property(e => e.CLOSE_LEVEL)
                .IsUnicode(false);
        }
    }
}
