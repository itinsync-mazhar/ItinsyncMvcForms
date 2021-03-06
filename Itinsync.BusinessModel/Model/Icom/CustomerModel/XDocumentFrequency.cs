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
    
    public partial class XDocumentFrequency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XDocumentFrequency()
        {
            this.Documents = new HashSet<Document>();
            this.DocumentAlerts = new HashSet<DocumentAlert>();
            this.XDocumentUserAlerts = new HashSet<XDocumentUserAlert>();
        }
    
        public int xDocumentFormFrequencyID { get; set; }
        public Nullable<int> storeID { get; set; }
        public string formType { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<System.DateTime> startTimeTime { get; set; }
        public Nullable<int> xDocumentDefinitionID { get; set; }
        public Nullable<byte> day { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string repeatFrequency { get; set; }
        public Nullable<int> parentFrequencyId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentAlert> DocumentAlerts { get; set; }
        public virtual Store Store { get; set; }
        public virtual XDocumentDefinition XDocumentDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentUserAlert> XDocumentUserAlerts { get; set; }
    }
}
