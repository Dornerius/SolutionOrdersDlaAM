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
    
    public partial class Dostawy
    {
        public int ID { get; set; }
        public Nullable<int> ID_Zamowienia { get; set; }
        public string FirmaKurierska { get; set; }
        public string NumerSledzenia { get; set; }
        public string StatusDostawy { get; set; }
    
        public virtual Zamowienia Zamowienia { get; set; }
    }
}
