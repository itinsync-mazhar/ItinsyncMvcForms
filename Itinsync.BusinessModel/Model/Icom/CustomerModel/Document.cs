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
    
    public partial class Document
    {
        public int documentID { get; set; }
        public string documentName { get; set; }
        public Nullable<int> documentDefinitionID { get; set; }
        public Nullable<int> transDate { get; set; }
        public Nullable<int> transTime { get; set; }
        public string status { get; set; }
        public string data { get; set; }
        public string type { get; set; }
        public string extension { get; set; }
        public string paramsXML { get; set; }
        public Nullable<int> userID { get; set; }
        public string filePath { get; set; }
        public Nullable<int> vendorID { get; set; }
        public Nullable<int> storeID { get; set; }
        public Nullable<int> flow { get; set; }
        public Nullable<double> latitude { get; set; }
        public Nullable<double> longitude { get; set; }
        public string parentRef { get; set; }
        public Nullable<long> transID { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> startDateTime { get; set; }
        public Nullable<int> frequencyID { get; set; }
    
        public virtual CrossTable_businesstransaction CrossTable_businesstransaction { get; set; }
        public virtual CrossTable_vendor CrossTable_vendor { get; set; }
        public virtual Document Document1 { get; set; }
        public virtual Document Document2 { get; set; }
        public virtual Store Store { get; set; }
        public virtual XDocumentDefinition XDocumentDefinition { get; set; }
        public virtual XDocumentFrequency XDocumentFrequency { get; set; }
    }
}