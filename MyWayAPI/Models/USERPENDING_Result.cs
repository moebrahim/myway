//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWayAPI.Models
{
    using System;
    
    public partial class USERPENDING_Result
    {
        public string DOC_ID { get; set; }
        public string DISTR_ID { get; set; }
        public string DISTRNAME { get; set; }
        public string COUNTER { get; set; }
        public string ITEM_ID { get; set; }
        public string ITEMNAME { get; set; }
        public Nullable<decimal> QTY_REQ { get; set; }
        public Nullable<decimal> UNIT_PRICE { get; set; }
        public Nullable<decimal> TOT_PRICE { get; set; }
        public Nullable<double> ITEM_BP { get; set; }
        public Nullable<double> TOTAL_BP { get; set; }
        public string DOC_DATE { get; set; }
        public string ADD_TIME { get; set; }
    }
}
