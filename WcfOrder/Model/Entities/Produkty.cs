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
    
    public partial class Produkty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkty()
        {
            this.KoszykProdukty = new HashSet<KoszykProdukty>();
            this.Opinie = new HashSet<Opinie>();
            this.Ulubione = new HashSet<Ulubione>();
            this.ZamowieniaProdukty = new HashSet<ZamowieniaProdukty>();
        }
    
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public Nullable<decimal> Cena { get; set; }
        public Nullable<int> IloscDostepna { get; set; }
        public Nullable<int> ID_RodzajProduktu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KoszykProdukty> KoszykProdukty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opinie> Opinie { get; set; }
        public virtual RodzajeProduktow RodzajeProduktow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ulubione> Ulubione { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZamowieniaProdukty> ZamowieniaProdukty { get; set; }
    }
}
