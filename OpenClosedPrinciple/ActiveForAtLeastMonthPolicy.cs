using System;

namespace OpenClosedPrinciple
{
    public class ActiveForAtLeastMonthPolicy : IPolicy<UserAccount>
    {
        public readonly int MinActivityPeriod = 3;
        public bool IsTestPassing(UserAccount subject)
        {
            var utcNow = DateTime.UtcNow;
            return (utcNow - subject.UtcActivatedAt).TotalDays > MinActivityPeriod;
        }
    }
}