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
    
    public partial class XDocumentTableTR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XDocumentTableTR()
        {
            this.XDocumentTableTDs = new HashSet<XDocumentTableTD>();
        }
    
        public int trID { get; set; }
        public string trControlID { get; set; }
        public string cssClass { get; set; }
        public Nullable<int> documentTableID { get; set; }
        public Nullable<int> row { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual XDocumentTable XDocumentTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentTableTD> XDocumentTableTDs { get; set; }
    }
}
