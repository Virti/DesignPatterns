using System;

namespace OpenClosedPrinciple
{
    public class UserAccount
    {
        public DateTime UtcLastPasswordChange { get; set; }
        public DateTime UtcActivatedAt { get; set; }
    }
}