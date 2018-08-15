namespace MyWayAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class A9 : DbContext
    {
        public A9()
            : base("name=A9")
        {
        }

        public virtual DbSet<ACC011A9> ACC011A9 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.TRANS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.VOU_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.VOU_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.ADESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.LDESCR)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.PRJ_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.STORE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.TO_PRJ_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.TO_ST_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.CUS_VEN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.BRANCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.RES_SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.DOC_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.DOC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.TRNSF_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.USE_RSRV)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.GEN_VOUCH)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.ORG_VOU)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.POSTED)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.NO_MODIFY)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.SENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.ADD_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.LAST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.HELD)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.COMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.REFERENCE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.V_DISTR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.ADD_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.LAST_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.GL_JVR_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.GL_TRANS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.S_SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.REC_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.IS_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.CLOSE_LEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.DS_SHIPMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.ISSUE_ORDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ACC011A9>()
                .Property(e => e.ST_SUM_DUPLICATE_ITEMS)
                .IsUnicode(false);
        }
    }
}
