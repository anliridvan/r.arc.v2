using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Clients
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string Secret { get; set; }
        public string[] AllowedScopes { get; set; }
        public bool IsEnabled { get; set; }
        public int AccessTokenLifeTime { get; set; }
    }
}
