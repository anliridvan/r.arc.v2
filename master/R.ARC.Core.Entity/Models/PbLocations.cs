using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class PbLocations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string[] Photos { get; set; }
        public string Logo { get; set; }
        public string[] ClockList { get; set; }
        public string ResponsibleName { get; set; }
        public string ResponsiblePhone { get; set; }
        public string ResponsibleEmail { get; set; }
        public string CompanyTitle { get; set; }
        public int? BankId { get; set; }
        public string TaxOfficeId { get; set; }
        public string TaxNumber { get; set; }
        public string Iban { get; set; }
        public string OfficialInvoiceAddress { get; set; }
        public int? CityId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
