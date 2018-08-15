namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC011AQ
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string DOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string COUNTER { get; set; }

        [Required]
        [StringLength(20)]
        public string ITEM_ID { get; set; }

        [StringLength(20)]
        public string UNIT { get; set; }

        public decimal? QTY_QUOT { get; set; }

        public decimal? QTY_REQ { get; set; }

        public decimal? UNIT_PRICE { get; set; }

        public decimal? DISC_RATIO { get; set; }

        public decimal? DISC_VAL { get; set; }

        public decimal? NET_PRICE { get; set; }

        public decimal? TOT_PRICE { get; set; }

        public decimal? QTY_DLV { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        [StringLength(10)]
        public string OWNER { get; set; }

        [StringLength(3)]
        public string MODULE_ID { get; set; }

        public double PACK_UNITS { get; set; }

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

        public double? ITEM_BP { get; set; }

        public double? ITEM_BV { get; set; }

        public double? ST_QTY { get; set; }

        [StringLength(20)]
        public string OFFER_ITEM_ID { get; set; }

        [StringLength(20)]
        public string OFFER2_ITEM_ID { get; set; }

        [StringLength(20)]
        public string DS_PRIZE_ROW_ID { get; set; }

        [StringLength(10)]
        public string GIFT_TYPE { get; set; }
    }
}
