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
    
    public partial class CrossTable_pagename
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrossTable_pagename()
        {
            this.XDocumentSections = new HashSet<XDocumentSection>();
            this.XDocumentSections1 = new HashSet<XDocumentSection>();
        }
    
        public int pageID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentSection> XDocumentSections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XDocumentSection> XDocumentSections1 { get; set; }
    }
}
