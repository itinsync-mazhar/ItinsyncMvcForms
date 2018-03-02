//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Itinsync.BusinessModel.Model.Icom.CustomerModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class XReportDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XReportDefinition()
        {
            this.XReportSections = new HashSet<XReportSection>();
            this.XReportTables = new HashSet<XReportTable>();
        }
    
        public int xReportDefinitionID { get; set; }
        public Nullable<int> documentDefinitionID { get; set; }
        public Nullable<int> vendorID { get; set; }
        public string name { get; set; }
        public bool status { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual CrossTable_vendor CrossTable_vendor { get; set; }
        public virtual XDocumentDefinition XDocumentDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XReportSection> XReportSections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XReportTable> XReportTables { get; set; }
    }
}