namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A000032C
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string MODULE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string COMP_ID { get; set; }

        public short? LANGUAGE { get; set; }

        [StringLength(1)]
        public string TON_SSAP { get; set; }

        [StringLength(50)]
        public string DATA_DB { get; set; }

        [StringLength(50)]
        public string DATA_DRVR { get; set; }

        [StringLength(50)]
        public string DATA_SRVR { get; set; }

        [StringLength(50)]
        public string DATA_USER { get; set; }

        [StringLength(50)]
        public string DATA_PASS { get; set; }

        [StringLength(50)]
        public string TITLE_ATTR { get; set; }

        [StringLength(50)]
        public string CAP_ATTR { get; set; }

        [StringLength(50)]
        public string EDIT_FONT { get; set; }

        [StringLength(1)]
        public string EDIT_3D { get; set; }

        [StringLength(1)]
        public string EDIT_SHADE { get; set; }

        public double? EDIT_COLOR { get; set; }

        public double? DS_COLOR { get; set; }

        [StringLength(1)]
        public string R_USER { get; set; }

        [StringLength(50)]
        public string R_CAPFNT { get; set; }

        [StringLength(50)]
        public string R_T_HDRFNT { get; set; }

        [StringLength(50)]
        public string R_G_HDRFNT { get; set; }

        [StringLength(50)]
        public string R_COLFNT { get; set; }

        [StringLength(50)]
        public string R_FOOTFNT { get; set; }

        [StringLength(1)]
        public string G_USER { get; set; }

        [StringLength(50)]
        public string G_HDRFNT { get; set; }

        [StringLength(50)]
        public string G_FOOTFNT { get; set; }

        public double? G_CCLR { get; set; }

        public double? G_SCCLR { get; set; }

        public double? G_ICLR { get; set; }

        public double? G_HCLR { get; set; }

        public double? G_MHCLR { get; set; }

        public double? G_MCLR { get; set; }

        [StringLength(10)]
        public string YEAR_START { get; set; }

        public int? START_OPEN { get; set; }

        public int? FIRST_OPEN { get; set; }

        public int? LAST_OPEN { get; set; }

        public int? PER_LEN { get; set; }

        public int? SHIFTS { get; set; }

        public double? S_AUTO_KEY { get; set; }

        [StringLength(2)]
        public string USER_ID { get; set; }

        [StringLength(10)]
        public string ADD_DATE { get; set; }

        [StringLength(10)]
        public string LAST_DATE { get; set; }

        [StringLength(3)]
        public string CNSLD_COMP { get; set; }

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

        [StringLength(50)]
        public string SYS_PREFIX { get; set; }

        [StringLength(10)]
        public string CLOSE_DATE { get; set; }

        [StringLength(50)]
        public string ACTV_KEY { get; set; }
    }
}
