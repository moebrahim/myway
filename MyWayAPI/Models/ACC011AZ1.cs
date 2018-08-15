namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC011AZ1
    {
        [Key]
        [StringLength(20)]
        public string DISTR_ID { get; set; }

        [StringLength(40)]
        public string FAMILY_ANAME { get; set; }

        [StringLength(40)]
        public string FAMILY_LNAME { get; set; }

        [StringLength(100)]
        public string ANAME { get; set; }

        [StringLength(100)]
        public string LNAME { get; set; }

        [StringLength(2)]
        public string ID_LEVEL { get; set; }

        [StringLength(1)]
        public string DETAILED { get; set; }

        [StringLength(255)]
        public string ICODE { get; set; }

        public float? DISTR_LEVEL { get; set; }

        public int? DISTR_ORDER { get; set; }

        [StringLength(20)]
        public string SERVICE_CENTER { get; set; }

        [StringLength(20)]
        public string SHIFT_ID { get; set; }

        [StringLength(50)]
        public string JOIN_DATE { get; set; }

        [StringLength(10)]
        public string LAST_INV_DATE { get; set; }

        [StringLength(10)]
        public string DISTR_STATUS { get; set; }

        [StringLength(20)]
        public string SPONSOR_ID { get; set; }

        [StringLength(20)]
        public string CURRENT_DISTR_TYPE_ID { get; set; }

        [StringLength(20)]
        public string DIRECTOR_ID { get; set; }

        [StringLength(255)]
        public string YEAR_DISTR_TYPE { get; set; }

        [StringLength(50)]
        public string DISTR_IDENT { get; set; }

        [StringLength(100)]
        public string IDENT_APLACE { get; set; }

        [StringLength(100)]
        public string IDENT_LPLACE { get; set; }

        [StringLength(10)]
        public string BIRTH_DATE { get; set; }

        public double? DUE_DAYS { get; set; }

        [StringLength(20)]
        public string SM_ID { get; set; }

        [StringLength(20)]
        public string GROUP_ID { get; set; }

        [StringLength(20)]
        public string AREA_ID { get; set; }

        [StringLength(60)]
        public string AADDRESS { get; set; }

        [StringLength(60)]
        public string LADDRESS { get; set; }

        [StringLength(15)]
        public string TELEPHONE { get; set; }

        [StringLength(15)]
        public string FAX { get; set; }

        [StringLength(1)]
        public string HELD { get; set; }

        [StringLength(1)]
        public string HOLD_PAY { get; set; }

        [StringLength(1)]
        public string HOLD_CRE { get; set; }

        public double? BALANCE { get; set; }

        public double? CRE_LIMIT { get; set; }

        [StringLength(10)]
        public string OWNER { get; set; }

        [StringLength(2)]
        public string MODULE_ID { get; set; }

        [StringLength(3)]
        public string COMP_ID { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        [StringLength(30)]
        public string E_MAIL { get; set; }

        [StringLength(1)]
        public string CR_LMT_TYP { get; set; }

        [StringLength(100)]
        public string ATERMS { get; set; }

        [StringLength(100)]
        public string LTERMS { get; set; }

        [StringLength(20)]
        public string AR_AC_ID { get; set; }

        [StringLength(20)]
        public string AP_AC_ID { get; set; }

        [StringLength(10)]
        public string ADD_DATE { get; set; }

        [StringLength(10)]
        public string LAST_DATE { get; set; }

        [StringLength(12)]
        public string USER_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_AUTO_KEY { get; set; }

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

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [Column(TypeName = "money")]
        public decimal? REG_FEES { get; set; }

        [Column(TypeName = "money")]
        public decimal? PAID_FEES { get; set; }

        [StringLength(20)]
        public string CM_FEES_ID { get; set; }

        [StringLength(1)]
        public string FEES_TYPE { get; set; }

        public int? MAX_TYPE_LEVEL { get; set; }

        [StringLength(12)]
        public string YEAR_STATUS { get; set; }

        [StringLength(20)]
        public string KIT_ST_VOU_ID { get; set; }

        [StringLength(10)]
        public string LAST_RENEWAL_DATE { get; set; }

        public float? MAX_BONUS_RATIO { get; set; }

        public int? SEPARATED_LEVEL { get; set; }

        [StringLength(200)]
        public string NOTES { get; set; }

        [StringLength(1)]
        public string CAN_NOT_RETURN { get; set; }
    }
}
