//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BirthdayCake.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public int OrderID { get; set; }
        public System.DateTime DateTimeOrder { get; set; }
        public int Guest { get; set; }
        public int TotalPrice { get; set; }
        public int TotalCake { get; set; }
        public string CakeList { get; set; }
    
        public virtual tblGuest tblGuest { get; set; }
    }
}
