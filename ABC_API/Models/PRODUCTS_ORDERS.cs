//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTS_ORDERS
    {
        public int ID { get; set; }
        public int Order_ID { get; set; }
        public int ID_Product { get; set; }
        public int Quantity { get; set; }
    
        public virtual ORDERS ORDERS { get; set; }
        public virtual PRODUCTS PRODUCTS { get; set; }
    }
}
