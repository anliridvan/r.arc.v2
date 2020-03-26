using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class BackendErrors
    {
        public int Id { get; set; }
        public DateTime DateOccurred { get; set; }
        public string ErrorString { get; set; }
        public string UrlPath { get; set; }
        public string AccessToken { get; set; }
        public string Ip { get; set; }
    }
}
