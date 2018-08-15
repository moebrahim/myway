namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AZ1 : DbContext
    {
        public AZ1()
            : base("name=AZ1")
        {
        }

        public virtual DbSet<ACC011AZ1> ACC011AZ1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.DISTR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.FAMILY_ANAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.FAMILY_LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ANAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ID_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.DETAILED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ICODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.SERVICE_CENTER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.SHIFT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.JOIN_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LAST_INV_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.DISTR_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.SPONSOR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.CURRENT_DISTR_TYPE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.DIRECTOR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.YEAR_DISTR_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.DISTR_IDENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.IDENT_APLACE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.IDENT_LPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.BIRTH_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.SM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.GROUP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.AREA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.AADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.TELEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.HELD)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.HOLD_PAY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.HOLD_CRE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.E_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.CR_LMT_TYP)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ATERMS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LTERMS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.AR_AC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.AP_AC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.S_AUTO_KEY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.REG_FEES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.PAID_FEES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.CM_FEES_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.FEES_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.YEAR_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.KIT_ST_VOU_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.LAST_RENEWAL_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.NOTES)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AZ1>()
                .Property(e => e.CAN_NOT_RETURN)
                .IsUnicode(false);
        }
    }
}
