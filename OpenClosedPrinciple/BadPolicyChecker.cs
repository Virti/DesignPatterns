using System;

namespace OpenClosedPrinciple
{
    public class BadPolicyChecker
    {
        public bool MeetsAllPolicies(UserAccount userAccount, object[] policies)
        {
            foreach (var policy in policies)
            {
                DateTime utcNow = DateTime.UtcNow;

                if (policy is OneMonthPasswordRetentionPolicy)
                {
                    var prp = (OneMonthPasswordRetentionPolicy) policy;
                    if ((utcNow - userAccount.UtcLastPasswordChange).TotalDays > prp.MaxPasswordAge)
                        return false;
                }

                if (policy is ActiveForAtLeastMonthPolicy)
                {
                    var afalmp = (ActiveForAtLeastMonthPolicy) policy;
                    if ((utcNow - userAccount.UtcActivatedAt).TotalDays <= afalmp.MinActivityPeriod)
                        return false;
                }

                /*
                 * Now imagine how would that method look like if we had
                 * 30-40 policies to check.
                 *
                 * Even more - imagine, that we'd like to implement way to allow
                 * at least one policy (not all) in another method. Above solution would
                 * quickly lead us to having a lots and lots of hard to read code.
                 *
                 * Let's instead try to make each policy "check itself" for us
                 * (see NicePolicyChecker.cs)
                 */
            }

            return true;
        }
    }
}