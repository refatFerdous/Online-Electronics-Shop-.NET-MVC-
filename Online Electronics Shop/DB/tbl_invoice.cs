//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Electronics_Shop.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_invoice()
        {
            this.Tbl_ShippingDetails = new HashSet<Tbl_ShippingDetails>();
            this.tbl_order = new HashSet<tbl_order>();
            this.tbl_delivery = new HashSet<tbl_delivery>();
        }
    
        public int in_id { get; set; }
        public Nullable<int> in_fk_user { get; set; }
        public Nullable<System.DateTime> in_date { get; set; }
        public Nullable<double> in_totalbill { get; set; }
    
        public virtual SiteUser SiteUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ShippingDetails> Tbl_ShippingDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order> tbl_order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_delivery> tbl_delivery { get; set; }
    }
}
