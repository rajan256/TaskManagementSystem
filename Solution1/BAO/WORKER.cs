//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class WORKER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WORKER()
        {
            this.TASK_ASSIGNMENT = new HashSet<TASK_ASSIGNMENT>();
        }
    
        public int ID { get; set; }
        public Nullable<int> WORKER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USER_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK_ASSIGNMENT> TASK_ASSIGNMENT { get; set; }
    }
}
