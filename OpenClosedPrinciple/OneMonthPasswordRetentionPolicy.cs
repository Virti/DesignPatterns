using System;

namespace OpenClosedPrinciple
{
    public class OneMonthPasswordRetentionPolicy : IPolicy<UserAccount>
    {
        public readonly int MaxPasswordAge = 30;
        public bool IsTestPassing(UserAccount subject)
        {
            var utcNow = DateTime.UtcNow;
            return (utcNow - subject.UtcLastPasswordChange).TotalDays <= MaxPasswordAge;
        }
    }
}