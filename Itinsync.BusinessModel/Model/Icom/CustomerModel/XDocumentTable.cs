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
    
    public partial class XDocumentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XDocumentTable()
        {
            this.XDocumentTableTRs = new HashSet<XDocumentTableTR>();
        }
    
        public int documentTableID { get; set; }
        public Nullable<int> documentSectionID { get; set; }
        public string dataToggle { get; set; }
        public string tableControlID { get; set; }
        public string cssClass { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual XDocumentSection XDocumentSection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentTableTR> XDocumentTableTRs { get; set; }
    }
}
