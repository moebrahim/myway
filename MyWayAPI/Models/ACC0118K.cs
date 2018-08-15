namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACC0118K
    {
        [Key]
        [StringLength(20)]
        public string AREA_ID { get; set; }

        [StringLength(30)]
        public string LSHORT { get; set; }

        [StringLength(30)]
        public string ASHORT { get; set; }

        [StringLength(60)]
        public string LNAME { get; set; }

        [StringLength(60)]
        public string ANAME { get; set; }

        [StringLength(1)]
        public string DETAILED { get; set; }

        [StringLength(10)]
        public string OWNER { get; set; }

        [StringLength(2)]
        public string MODULE_ID { get; set; }

        [StringLength(3)]
        public string COMP_ID { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

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
    }
}
