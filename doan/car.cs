//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doan
{
    using System;
    using System.Collections.Generic;
    
    public partial class car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public car()
        {
            this.staff = new HashSet<staff>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public System.DateTime created_at { get; set; }
        public string color { get; set; }
        public int year_created { get; set; }
        public Nullable<int> distributorId { get; set; }
    
        public virtual distributor distributor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staff> staff { get; set; }
    }
}
