//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Itinsync.NonBusinessModel.Model.Icom.ItinsyncModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class vendordevice
    {
        public int deviceID { get; set; }
        public string deviceName { get; set; }
        public string osVersion { get; set; }
        public string accessToken { get; set; }
        public Nullable<int> vendorID { get; set; }
        public Nullable<System.DateTime> transDateTime { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> cacheCount { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual BusinessTransaction BusinessTransaction { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
