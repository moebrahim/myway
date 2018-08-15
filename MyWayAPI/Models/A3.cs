namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class A3 : DbContext
    {
        public A3()
            : base("name=A3")
        {
        }

        public virtual DbSet<ACC011A3> ACC011A3 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ASHORT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.LSHORT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ANAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.IT_GRP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.M_VENDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ITEM_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.COSTING)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ITEM_ACTV)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PR_PART_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.HAS_EX_DAT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.AUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.LUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.VENDOR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.P_P_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.V_PART_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.SHELF_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.BIN_LOC)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.IS_FIXED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.HELD)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.CC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.TAX_FREE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.B_M_REF_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.BAR_CODE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.CLOSE_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.S_ALTERNATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.IS_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.IS_BOM)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.DETAILED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.ID_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.CAN_DLV)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.DS_ITEM_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.FOR_EXIST_QTY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PRIZE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PRIZE_ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PRIZE_DS_ITEM_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.OFFER_FROM_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.OFFER_TO_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PRIZE2_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PRIZE2_ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.PRIZE2_DS_ITEM_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A3>()
                .Property(e => e.NO_DISCOUNT)
                .IsUnicode(false);
        }
    }
}
