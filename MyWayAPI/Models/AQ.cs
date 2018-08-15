namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AQ : DbContext
    {
        public AQ()
            : base("name=AQ")
        {
        }

        public virtual DbSet<ACC011AQ> ACC011AQ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.DOC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.COUNTER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.QTY_QUOT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.QTY_REQ)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.DISC_RATIO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.DISC_VAL)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.NET_PRICE)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.TOT_PRICE)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.QTY_DLV)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.OFFER_ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.OFFER2_ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.DS_PRIZE_ROW_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AQ>()
                .Property(e => e.GIFT_TYPE)
                .IsUnicode(false);
        }
    }
}
