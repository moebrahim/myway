namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AP : DbContext
    {
        public AP()
            : base("name=AP")
        {
        }

        public virtual DbSet<ACC011AP> ACC011AP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DOC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DOC_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.QUOT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.QUOT_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DISTR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.SM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.SA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.SL_LOC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.SHIPMTHD_A)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.SHIPMTHD_L)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.GROSS_TOTAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DISC_VAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.NET_TOTAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.ADDED_TAX)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DED_TAX)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.NET_AFTER_TAX)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.ADELIVERY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.LDELIVERY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.APAYMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.LPAYMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.AREMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.LREMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.CLOSEDFLAG)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.HELD)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.PRJ_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.CUST_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.STORE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.EXP_DLV_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.CREATE_RSRV)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.RSRV_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.CLOSE_LEVEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.ST_CLOSED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DS_SHIPMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DS_SHIPMENT_COMP)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DS_SHIPMENT_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AP>()
                .Property(e => e.DISC_NOTES)
                .IsUnicode(false);
        }
    }
}
