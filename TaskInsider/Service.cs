//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskInsider
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ServiceRequests = new HashSet<ServiceRequest>();
        }
    
        public int ServiceID { get; set; }
        public int ServiceTypeID { get; set; }
        public int InsiderID { get; set; }
        public string ServiceName { get; set; }
        public decimal HourlyRate { get; set; }
        public int MinBookableHours { get; set; }
        public decimal ServiceCharge { get; set; }
    
        public virtual Insider Insider { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}