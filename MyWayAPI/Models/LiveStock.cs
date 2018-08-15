namespace MyWayAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("liveStock")]
    public partial class liveStock
    {
        [Key]
        [StringLength(10)]
        public string itemId { get; set; }

        public int? qty { get; set; }
    }
}
