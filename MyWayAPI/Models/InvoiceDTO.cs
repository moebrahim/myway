using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWayAPI.Models
{
    public class InvoiceDTO
    {
        public ACC011AP apmaster { set; get; }
        public List<ACC011AQ> aqdetail { set; get; }
        public ACC011A9 a9master { set; get; }
        public List<ACC011AA> aadetail { set; get; }
        public A000032C period { set; get; }
    }
}