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
    
    public partial class RodzajeProduktow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RodzajeProduktow()
        {
            this.Produkty = new HashSet<Produkty>();
        }
    
        public int ID { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty> Produkty { get; set; }
    }
}
