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
    
    public partial class XDocumentReferedContent
    {
        public int referedContentID { get; set; }
        public Nullable<int> documentSectionID { get; set; }
        public string controlID { get; set; }
        public string translation { get; set; }
        public Nullable<int> documentDefinitionID { get; set; }
        public Nullable<int> documentContentID { get; set; }
        public Nullable<bool> isFrwdToNextSubmittedForms { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual XDocumentDefinition XDocumentDefinition { get; set; }
        public virtual XDocumentSection XDocumentSection { get; set; }
        public virtual XDocumentTableContent XDocumentTableContent { get; set; }
    }
}