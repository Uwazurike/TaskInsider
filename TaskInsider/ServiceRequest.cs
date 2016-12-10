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
    
    public partial class ServiceRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceRequest()
        {
            this.Payments = new HashSet<Payment>();
            this.ServiceOrderItems = new HashSet<ServiceOrderItem>();
            this.ServiceRequest1 = new HashSet<ServiceRequest>();
        }
    
        public int ServiceRequestID { get; set; }
        public int ClientID { get; set; }
        public Nullable<int> RelatedServiceRequestID { get; set; }
        public int ServiceID { get; set; }
        public int InsiderID { get; set; }
        public Nullable<int> HoursOverMinimum { get; set; }
        public int TotalHoursWorked { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> FinalEarnings { get; set; }
        public int ClientPaymentStatusID { get; set; }
        public int RequestStatusID { get; set; }
        public Nullable<System.DateTime> ServiceCompletionDate { get; set; }
        public int InsiderPayStatusID { get; set; }
        public Nullable<System.DateTime> InsiderPayDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ClientPaymentStatu ClientPaymentStatu { get; set; }
        public virtual Insider Insider { get; set; }
        public virtual InsiderPayStatu InsiderPayStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual RequestStatu RequestStatu { get; set; }
        public virtual Service Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOrderItem> ServiceOrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRequest> ServiceRequest1 { get; set; }
        public virtual ServiceRequest ServiceRequest2 { get; set; }
    }
}
