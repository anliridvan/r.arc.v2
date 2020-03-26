using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Invoices
    {
        public int Id { get; set; }
        public long? ProviderId { get; set; }
        public string ProviderType { get; set; }
        public string RefId { get; set; }
        public string RealInvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsProcessed { get; set; }
        public decimal? ChargedPrice { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public bool? PdfReady { get; set; }
        public bool? IsCancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
    }
}
