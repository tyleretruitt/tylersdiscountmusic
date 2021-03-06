//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCShoppingData
{
    using System;
    using System.Collections.Generic;
    
    public partial class MVCProduct
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProdDescription { get; set; }
        public decimal Price { get; set; }
        public string ModelNumber { get; set; }
        public string Image { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public int StatusID { get; set; }
        public int VendorID { get; set; }
    
        public virtual MVCCategory MVCCategory { get; set; }
        public virtual MVCStatus MVCStatus { get; set; }
        public virtual MVCVendor MVCVendor { get; set; }
    }
}
