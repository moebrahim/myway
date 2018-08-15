using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWayAPI.Models
{
    public class Pending
    {
        //public List<string> APQDoc_ID { get; set; }
        //public List<string> A9Vou_ID { get; set; }
        //public List<ACC011AP> AP { get; set; }
        //public List<ACC011AQ> AQ { get; set; }
        //public List<ACC011A3> prods { get; set; }
        //public IQueryable APQDoc_ID { get; set; }
        //public IQueryable item_id { get; set; }
        //public IQueryable itembp { get; set; }
        //public IQueryable itemprice { get; set; }
        //public IQueryable date { get; set; }
        //public IQueryable nettot { get; set; }
        public string docid { get; set; }
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public double? ItemSubTotalPoints { get; set; }
        
        public decimal? SubTotalPrice { get; set; }
    //{System.Data.Entity.Infrastructure.DbQuery<<>f__AnonymousType6<string,decimal?,double?,decimal?>>}
    }
}