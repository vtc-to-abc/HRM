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
    
    public partial class TakePartInNow
    {
        public string Proj_ID { get; set; }
        public string Employ_ID { get; set; }
        public Nullable<System.DateTime> date_join { get; set; }
    
        public virtual EmployeeNow EmployeeNow { get; set; }
        public virtual Project Project { get; set; }
    }
}
