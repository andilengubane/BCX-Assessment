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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.AssignedTask = new HashSet<AssignedTask>();
        }
    
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLast { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public Nullable<int> GenderId { get; set; }
        public System.DateTime DateLogged { get; set; }
        public Nullable<int> RileId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignedTask> AssignedTask { get; set; }
        public virtual DataLookUp DataLookUp { get; set; }
        public virtual Role Role { get; set; }
    }
}
