//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stadium.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stadiums
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stadiums()
        {
            this.Reserves = new HashSet<Reserves>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<byte> İsCovered { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserves> Reserves { get; set; }
    }
}
