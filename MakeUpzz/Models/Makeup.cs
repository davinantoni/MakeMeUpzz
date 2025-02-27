//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeUpzz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makeup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makeup()
        {
            this.Carts = new HashSet<Cart>();
            this.TransactionDetails = new HashSet<TransactionDetail>();
        }
    
        public int MakeupID { get; set; }
        public string MakeupName { get; set; }
        public int MakeupPrice { get; set; }
        public int MakeupWeight { get; set; }
        public int MakeupTypeID { get; set; }
        public int MakeupBrandID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual MakeupBrand MakeupBrand { get; set; }
        public virtual MakeupType MakeupType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
