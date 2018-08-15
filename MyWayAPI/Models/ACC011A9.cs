namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC011A9
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string TRANS_TYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string VOU_ID { get; set; }

        [StringLength(10)]
        public string VOU_DATE { get; set; }

        [StringLength(60)]
        public string ADESCR { get; set; }

        [StringLength(60)]
        public string LDESCR { get; set; }

        [StringLength(20)]
        public string PRJ_ID { get; set; }

        [StringLength(20)]
        public string STORE_ID { get; set; }

        [StringLength(20)]
        public string TO_PRJ_ID { get; set; }

        [StringLength(20)]
        public string TO_ST_ID { get; set; }

        [StringLength(20)]
        public string CUS_VEN_ID { get; set; }

        [StringLength(20)]
        public string BRANCH_ID { get; set; }

        [StringLength(1)]
        public string RES_SOURCE { get; set; }

        [StringLength(20)]
        public string DOC_TYPE { get; set; }

        [StringLength(20)]
        public string DOC_ID { get; set; }

        public short? RES_TIME { get; set; }

        public double? LABOR { get; set; }

        public double? MACHINERS { get; set; }

        public double? OTHER { get; set; }

        [StringLength(20)]
        public string TRNSF_TYPE { get; set; }

        [StringLength(1)]
        public string USE_RSRV { get; set; }

        [StringLength(1)]
        public string GEN_VOUCH { get; set; }

        public double? PERIOD_NO { get; set; }

        [StringLength(20)]
        public string ORG_VOU { get; set; }

        public double? TOTAL_COST { get; set; }

        [StringLength(1)]
        public string POSTED { get; set; }

        [StringLength(1)]
        public string NO_MODIFY { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        [StringLength(10)]
        public string OWNER { get; set; }

        [StringLength(3)]
        public string MODULE_ID { get; set; }

        [StringLength(20)]
        public string USER_ID { get; set; }

        [StringLength(10)]
        public string ADD_DATE { get; set; }

        [StringLength(10)]
        public string LAST_DATE { get; set; }

        [StringLength(1)]
        public string HELD { get; set; }

        [StringLength(3)]
        public string COMP_ID { get; set; }

        public double? S_AUTO_KEY { get; set; }

        [StringLength(20)]
        public string REFERENCE_NO { get; set; }

        [StringLength(20)]
        public string V_DISTR_ID { get; set; }

        [StringLength(10)]
        public string ADD_TIME { get; set; }

        [StringLength(20)]
        public string LAST_USER { get; set; }

        [StringLength(20)]
        public string GL_JVR_TYPE { get; set; }

        [StringLength(20)]
        public string GL_TRANS_NO { get; set; }

        [StringLength(20)]
        public string S_SERIAL { get; set; }

        [StringLength(1)]
        public string REC_OWNER { get; set; }

        [StringLength(1)]
        public string IS_TEMPLATE { get; set; }

        [StringLength(1)]
        public string CLOSE_LEVEL { get; set; }

        [StringLength(50)]
        public string DS_SHIPMENT { get; set; }

        [StringLength(30)]
        public string ISSUE_ORDER_ID { get; set; }

        [StringLength(1)]
        public string ST_SUM_DUPLICATE_ITEMS { get; set; }
    }
}
