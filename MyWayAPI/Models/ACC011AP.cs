namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC011AP
    {
        [Key]
        [StringLength(20)]
        public string DOC_ID { get; set; }

        [StringLength(10)]
        public string DOC_DATE { get; set; }

        [StringLength(20)]
        public string QUOT_ID { get; set; }

        [StringLength(10)]
        public string QUOT_DATE { get; set; }

        [StringLength(20)]
        public string DISTR_ID { get; set; }

        [StringLength(20)]
        public string SM_ID { get; set; }

        [StringLength(20)]
        public string SA_ID { get; set; }

        [StringLength(20)]
        public string SL_LOC_ID { get; set; }

        [StringLength(100)]
        public string SHIPMTHD_A { get; set; }

        [StringLength(100)]
        public string SHIPMTHD_L { get; set; }

        [Column(TypeName = "money")]
        public decimal? GROSS_TOTAL { get; set; }

        public double? DISC_RATIO { get; set; }

        [Column(TypeName = "money")]
        public decimal? DISC_VAL { get; set; }

        [Column(TypeName = "money")]
        public decimal? NET_TOTAL { get; set; }

        [Column(TypeName = "money")]
        public decimal? ADDED_TAX { get; set; }

        [Column(TypeName = "money")]
        public decimal? DED_TAX { get; set; }

        [Column(TypeName = "money")]
        public decimal? NET_AFTER_TAX { get; set; }

        [StringLength(60)]
        public string ADELIVERY { get; set; }

        [StringLength(60)]
        public string LDELIVERY { get; set; }

        [StringLength(60)]
        public string APAYMENT { get; set; }

        [StringLength(60)]
        public string LPAYMENT { get; set; }

        [StringLength(60)]
        public string AREMARKS { get; set; }

        [StringLength(60)]
        public string LREMARKS { get; set; }

        [StringLength(1)]
        public string CLOSEDFLAG { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        [StringLength(10)]
        public string OWNER { get; set; }

        [StringLength(3)]
        public string MODULE_ID { get; set; }

        [StringLength(1)]
        public string HELD { get; set; }

        [StringLength(20)]
        public string PRJ_ID { get; set; }

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

        [StringLength(20)]
        public string LAST_USER { get; set; }

        [StringLength(20)]
        public string S_SERIAL { get; set; }

        [StringLength(1)]
        public string REC_OWNER { get; set; }

        [StringLength(1)]
        public string IS_TEMPLATE { get; set; }

        [StringLength(20)]
        public string CUST_ID { get; set; }

        [StringLength(20)]
        public string STORE_ID { get; set; }

        [StringLength(10)]
        public string EXP_DLV_DATE { get; set; }

        [StringLength(1)]
        public string CREATE_RSRV { get; set; }

        [StringLength(20)]
        public string RSRV_ID { get; set; }

        [StringLength(1)]
        public string CLOSE_LEVEL { get; set; }

        [StringLength(10)]
        public string ST_CLOSED { get; set; }

        [StringLength(20)]
        public string DS_SHIPMENT { get; set; }

        [StringLength(20)]
        public string DS_SHIPMENT_COMP { get; set; }

        [StringLength(20)]
        public string DS_SHIPMENT_PLACE { get; set; }

        [StringLength(100)]
        public string DISC_NOTES { get; set; }
    }
}
