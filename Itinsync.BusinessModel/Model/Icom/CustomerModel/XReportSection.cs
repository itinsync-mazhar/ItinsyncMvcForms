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
    
    public partial class XReportSection
    {
        public int reportSectionTableID { get; set; }
        public Nullable<int> xReportDefinitionID { get; set; }
        public Nullable<int> xDocumentSectionID { get; set; }
        public Nullable<byte> row { get; set; }
        public Nullable<byte> cell { get; set; }
        public Nullable<byte> rowspan { get; set; }
        public Nullable<byte> colspan { get; set; }
        public string cssClass { get; set; }
        public Nullable<long> transID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual XDocumentSection XDocumentSection { get; set; }
        public virtual XReportDefinition XReportDefinition { get; set; }
    }
}