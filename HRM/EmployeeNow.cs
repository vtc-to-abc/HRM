//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalHRM
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeNow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeNow()
        {
            this.Departments = new HashSet<Department>();
            this.TakePartInNows = new HashSet<TakePartInNow>();
        }
    
        public string Employ_ID { get; set; }
        public string Career_ID { get; set; }
        public Nullable<int> salary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }
        public virtual JobOfDep JobOfDep { get; set; }
        public virtual HistoryEmployee HistoryEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TakePartInNow> TakePartInNows { get; set; }
    }
}
