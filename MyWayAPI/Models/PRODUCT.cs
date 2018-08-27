namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTS")]
    public partial class PRODUCT
    {
        [Key]
        [StringLength(50)]
        public string ITEM_ID { get; set; }

        public string ANAME { get; set; }

        public double? PRICE { get; set; }

        public double? BP { get; set; }

        public double? BV { get; set; }

        [StringLength(50)]
        public string PROMO { get; set; }

        public bool? CATALOG { get; set; }

        public bool? DISCONTINUED { get; set; }

        public bool? NEW { get; set; }
    }
}
