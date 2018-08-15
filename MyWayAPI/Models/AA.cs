namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AA : DbContext
    {
        public AA()
            : base("name=AA")
        {
        }

        public virtual DbSet<ACC011AA> ACC011AA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.TRANS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.VOU_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.VOU_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.STORE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.COUNTER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.ITEM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.BATCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.EXP_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.C_C_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.PACKING_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.REC_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.REL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.BRANCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.PRJ_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_09)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_08)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.BAR_CODE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_06)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_03)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_02)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_01)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_04)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_05)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.VOU_SIGN)
                .HasPrecision(9, 0);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.DC_FLD_07)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.ST_LOC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011AA>()
                .Property(e => e.V_DISTR_ID)
                .IsUnicode(false);
        }
    }
}
