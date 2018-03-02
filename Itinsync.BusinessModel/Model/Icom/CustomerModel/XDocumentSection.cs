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
    
    public partial class XDocumentSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XDocumentSection()
        {
            this.XDocumentReferedContents = new HashSet<XDocumentReferedContent>();
            this.XDocumentTables = new HashSet<XDocumentTable>();
            this.XReportSections = new HashSet<XReportSection>();
            this.XReportTableContents = new HashSet<XReportTableContent>();
        }
    
        public int documentSectionID { get; set; }
        public string name { get; set; }
        public Nullable<int> pageID { get; set; }
        public Nullable<int> flow { get; set; }
        public Nullable<int> documentDefinitionID { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> isReport { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual CrossTable_pagename CrossTable_pagename { get; set; }
        public virtual CrossTable_pagename CrossTable_pagename1 { get; set; }
        public virtual XDocumentDefinition XDocumentDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentReferedContent> XDocumentReferedContents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentTable> XDocumentTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XReportSection> XReportSections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XReportTableContent> XReportTableContents { get; set; }
    }
}