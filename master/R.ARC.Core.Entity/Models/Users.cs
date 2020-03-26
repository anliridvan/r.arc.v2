using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Users
    {
        public Users()
        {
            RideRefundRequestHistory = new HashSet<RideRefundRequestHistory>();
            UserClaims = new HashSet<UserClaims>();
            UserLogins = new HashSet<UserLogins>();
            UserRoles = new HashSet<UserRoles>();
            UserTokens = new HashSet<UserTokens>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MobilePhone { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public bool? IsEnabled { get; set; }
        public string AccessToken { get; set; }
        public string OneSignalId { get; set; }
        public int[] GeofenceIdList { get; set; }
        public bool? ControlcenterLogin { get; set; }
        public string Email { get; set; }
        public int[] ClaimIds { get; set; }
        public string Subject { get; set; }
        public string OtpToken { get; set; }
        public DateTime? LastSignedInAt { get; set; }
        public string AgentId { get; set; }

        public virtual ICollection<RideRefundRequestHistory> RideRefundRequestHistory { get; set; }
        public virtual ICollection<UserClaims> UserClaims { get; set; }
        public virtual ICollection<UserLogins> UserLogins { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<UserTokens> UserTokens { get; set; }
    }
}
