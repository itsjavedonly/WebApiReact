//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.React.AI.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SmartInvoiceDemo
    {
        public int ID { get; set; }
        public Nullable<bool> isProcessed { get; set; }
        public string clientName { get; set; }
        public string invoiceNumber { get; set; }
        public string invoiceAmount { get; set; }
        public Nullable<System.DateTime> invoiceDate { get; set; }
        public Nullable<System.DateTime> invoiceDueDate { get; set; }
        public string Description { get; set; }
        public string invoiceUrl { get; set; }
    }
}
