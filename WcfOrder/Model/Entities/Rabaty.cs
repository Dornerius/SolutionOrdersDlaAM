//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfOrder.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rabaty
    {
        public int ID { get; set; }
        public string KodRabatu { get; set; }
        public Nullable<decimal> ProcentRabatu { get; set; }
        public Nullable<System.DateTime> DataRozpoczecia { get; set; }
        public Nullable<System.DateTime> DataZakonczenia { get; set; }
    }
}
