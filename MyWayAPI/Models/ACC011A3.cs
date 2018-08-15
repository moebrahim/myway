namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC011A3
    {
        [Key]
        [StringLength(20)]
        public string ITEM_ID { get; set; }

        [StringLength(60)]
        public string ASHORT { get; set; }

        [StringLength(60)]
        public string LSHORT { get; set; }

        [StringLength(100)]
        public string ANAME { get; set; }

        [StringLength(100)]
        public string LNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string IT_GRP_ID { get; set; }

        public double? D_S_PRICE { get; set; }

        [StringLength(1)]
        public string M_VENDOR { get; set; }

        [StringLength(1)]
        public string ITEM_TYPE { get; set; }

        public double? COST { get; set; }

        [StringLength(1)]
        public string COSTING { get; set; }

        [StringLength(1)]
        public string ITEM_ACTV { get; set; }

        [StringLength(20)]
        public string PR_PART_NO { get; set; }

        public double? MAX_DISC { get; set; }

        public double? PU_REO_LMT { get; set; }

        public double? MIN_PROFIT { get; set; }

        [StringLength(1)]
        public string HAS_EX_DAT { get; set; }

        public double? RESV_QTY { get; set; }

        [StringLength(15)]
        public string AUNIT { get; set; }

        [StringLength(15)]
        public string LUNIT { get; set; }

        public double? WEIGHT { get; set; }

        [StringLength(20)]
        public string VENDOR_ID { get; set; }

        [StringLength(20)]
        public string P_P_NO { get; set; }

        [StringLength(20)]
        public string V_PART_NO { get; set; }

        [StringLength(50)]
        public string SHELF_NO { get; set; }

        [StringLength(50)]
        public string BIN_LOC { get; set; }

        [StringLength(10)]
        public string OWNER { get; set; }

        [StringLength(3)]
        public string MODULE_ID { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        public double? IN_ORD_QTY { get; set; }

        [StringLength(1)]
        public string IS_FIXED { get; set; }

        public double? PRICE { get; set; }

        public double? PRFT_RATIO { get; set; }

        public double? ROUND_TO { get; set; }

        [StringLength(1)]
        public string HELD { get; set; }

        [StringLength(20)]
        public string CC_ID { get; set; }

        [StringLength(1)]
        public string TAX_FREE { get; set; }

        public double? WEIGHT_FACTOR { get; set; }

        [StringLength(3)]
        public string COMP_ID { get; set; }

        [StringLength(10)]
        public string ADD_DATE { get; set; }

        [StringLength(10)]
        public string LAST_DATE { get; set; }

        [StringLength(12)]
        public string USER_ID { get; set; }

        public double? S_AUTO_KEY { get; set; }

        public double? UNITS { get; set; }

        [StringLength(20)]
        public string B_M_REF_NO { get; set; }

        [StringLength(10)]
        public string ADD_TIME { get; set; }

        [StringLength(20)]
        public string LAST_USER { get; set; }

        [Required]
        [StringLength(20)]
        public string S_SERIAL { get; set; }

        [StringLength(1)]
        public string REC_OWNER { get; set; }

        public double? VOLUM { get; set; }

        [StringLength(1)]
        public string IS_TEMPLATE { get; set; }

        [StringLength(20)]
        public string BAR_CODE_ID { get; set; }

        [StringLength(1)]
        public string CLOSE_LEVEL { get; set; }

        [StringLength(20)]
        public string S_ALTERNATE_ID { get; set; }

        public double? PRODUCT_CAPACITY { get; set; }

        [StringLength(1)]
        public string IS_PRODUCT { get; set; }

        [StringLength(1)]
        public string IS_BOM { get; set; }

        [StringLength(1)]
        public string DETAILED { get; set; }

        [StringLength(1)]
        public string ID_LEVEL { get; set; }

        [StringLength(1)]
        public string CAN_DLV { get; set; }

        [StringLength(50)]
        public string DS_ITEM_CATEGORY { get; set; }

        public double? ITEM_WEIGHT { get; set; }

        [StringLength(1)]
        public string FOR_EXIST_QTY { get; set; }

        [StringLength(1)]
        public string PRIZE_TYPE { get; set; }

        [StringLength(50)]
        public string PRIZE_ITEM_ID { get; set; }

        [StringLength(50)]
        public string PRIZE_DS_ITEM_CATEGORY { get; set; }

        public double? OFFER_ITEM_QTY { get; set; }

        public double? PRIZE_ITEM_QTY { get; set; }

        public double? OFFER_INV_BP { get; set; }

        [StringLength(10)]
        public string OFFER_FROM_DATE { get; set; }

        [StringLength(10)]
        public string OFFER_TO_DATE { get; set; }

        [StringLength(1)]
        public string PRIZE2_TYPE { get; set; }

        [StringLength(50)]
        public string PRIZE2_ITEM_ID { get; set; }

        [StringLength(50)]
        public string PRIZE2_DS_ITEM_CATEGORY { get; set; }

        public double? OFFER2_ITEM_QTY { get; set; }

        public double? PRIZE2_ITEM_QTY { get; set; }

        [StringLength(1)]
        public string NO_DISCOUNT { get; set; }

        public double? BAG_RATIO { get; set; }
    }
}
