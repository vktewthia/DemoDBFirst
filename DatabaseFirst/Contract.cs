//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public Contract()
        {
            this.RentReceipts = new HashSet<RentReceipt>();
        }
    
        public int Key { get; set; }
        public int ContractType { get; set; }
        public System.DateTime BookedDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDateApprox { get; set; }
        public int Duration { get; set; }
        public decimal RentFixedPerMonth { get; set; }
        public decimal SecurityAmount { get; set; }
        public decimal SecurityAmountDeposit { get; set; }
        public bool IsSecurityPaid { get; set; }
        public int SecurityMonths { get; set; }
        public int ElectricityUnitRate { get; set; }
        public int ElectricityUnitStart { get; set; }
        public decimal MaintenanceCharge { get; set; }
        public decimal WiFiCharge { get; set; }
        public bool IsWifiOpted { get; set; }
        public decimal RoCharge { get; set; }
        public decimal OtherCharge { get; set; }
        public bool IsOnNotice { get; set; }
        public Nullable<System.DateTime> TerminateDate { get; set; }
        public bool IsTerminated { get; set; }
        public bool IsSecurityAmountReturned { get; set; }
        public int TenantKey { get; set; }
        public int RentalPropertyKey { get; set; }
    
        public virtual RentalProperty RentalProperty { get; set; }
        public virtual TenantInfo TenantInfo { get; set; }
        public virtual ICollection<RentReceipt> RentReceipts { get; set; }
    }
}
