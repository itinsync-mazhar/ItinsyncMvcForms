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
    
    public partial class Permission
    {
        public int permissionID { get; set; }
        public Nullable<int> code { get; set; }
        public string text { get; set; }
        public Nullable<int> pageID { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual BusinessTransaction BusinessTransaction { get; set; }
        public virtual PageName PageName { get; set; }
    }
}
