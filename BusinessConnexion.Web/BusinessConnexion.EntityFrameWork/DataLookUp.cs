//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessConnexion.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataLookUp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataLookUp()
        {
            this.Employee = new HashSet<Employee>();
        }
    
        public int Id { get; set; }
        public Nullable<int> DataLockId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateLogged { get; set; }
    
        public virtual DataLocked DataLocked { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
