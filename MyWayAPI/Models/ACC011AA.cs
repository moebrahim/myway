namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC011AA
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

        [StringLength(20)]
        public string STORE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string COUNTER { get; set; }

        [StringLength(20)]
        public string ITEM_ID { get; set; }

        [StringLength(20)]
        public string BATCH_ID { get; set; }

        [StringLength(10)]
        public string EXP_DATE { get; set; }

        [StringLength(20)]
        public string C_C_ID { get; set; }

        [StringLength(20)]
        public string PACKING_ID { get; set; }

        public double? PACK_UNITS { get; set; }

        public double? QTY { get; set; }

        public double? ITEM_COST { get; set; }

        public double? TOTAL_COST { get; set; }

        public double? LAST_COST { get; set; }

        public double? PRICE { get; set; }

        public double? RATIO { get; set; }

        public double? UNITS_NO { get; set; }

        [StringLength(1)]
        public string REC_TYPE { get; set; }

        [StringLength(20)]
        public string REL_ID { get; set; }

        public double? PERIOD_NO { get; set; }

        [StringLength(20)]
        public string BRANCH_ID { get; set; }

        public double? NEW_COST { get; set; }

        public double? DLV_QTY { get; set; }

        [StringLength(20)]
        public string PRJ_ID { get; set; }

        [StringLength(2)]
        public string MODULE_ID { get; set; }

        [StringLength(3)]
        public string COMP_ID { get; set; }

        [StringLength(10)]
        public string ADD_DATE { get; set; }

        [StringLength(10)]
        public string LAST_DATE { get; set; }

        [StringLength(12)]
        public string USER_ID { get; set; }

        public double? S_AUTO_KEY { get; set; }

        [StringLength(10)]
        public string ADD_TIME { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        [StringLength(20)]
        public string LAST_USER { get; set; }

        [StringLength(20)]
        public string S_SERIAL { get; set; }

        [StringLength(1)]
        public string REC_OWNER { get; set; }

        [StringLength(1)]
        public string IS_TEMPLATE { get; set; }

        public float? PACKAGE_UNITS_02 { get; set; }

        public float? PACKAGE_UNITS_03 { get; set; }

        public float? PACKAGE_QTY_04 { get; set; }

        public float? PACKAGE_UNITS_04 { get; set; }

        [StringLength(20)]
        public string DC_FLD_09 { get; set; }

        [StringLength(20)]
        public string DC_FLD_08 { get; set; }

        [StringLength(20)]
        public string BAR_CODE_ID { get; set; }

        [StringLength(20)]
        public string DC_FLD_06 { get; set; }

        [StringLength(20)]
        public string DC_FLD_03 { get; set; }

        [StringLength(20)]
        public string DC_FLD_02 { get; set; }

        [StringLength(20)]
        public string DC_FLD_01 { get; set; }

        [StringLength(20)]
        public string DC_FLD_04 { get; set; }

        [StringLength(20)]
        public string DC_FLD_05 { get; set; }

        public decimal? VOU_SIGN { get; set; }

        public float? PACKAGE_QTY_03 { get; set; }

        public float? PACKAGE_QTY_02 { get; set; }

        public float? PACKAGE_QTY_01 { get; set; }

        public float? PACKAGE_UNITS_01 { get; set; }

        [StringLength(20)]
        public string DC_FLD_07 { get; set; }

        public float? QTY2 { get; set; }

        [StringLength(20)]
        public string ST_LOC_ID { get; set; }

        [StringLength(20)]
        public string V_DISTR_ID { get; set; }
    }
}
