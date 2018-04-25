namespace OpenClosedPrinciple
{
    public class NicePolicyChecker
    {
        public virtual bool MeetsAllPolicies(UserAccount userAccount, IPolicy<UserAccount>[] policies)
        {
            /*
             * To make this possible, we need to create IPolicy<T> interface that all policies will implement.
             */

            foreach (var policy in policies)
            {
                if (!policy.IsTestPassing(userAccount))
                    return false;
            }

            return true;

            /*
             * The only reason why we would like ever to modify above method is because of optimization reasonse,
             * but even then we can simply override MeetsAllPolicies method
             */
        }

        /* Just to show how simple it is now */
        public virtual bool MeetsAtLEastOnePolicy(UserAccount userAccount, IPolicy<UserAccount>[] policies)
        {
            foreach (var policy in policies)
            {
                if (policy.IsTestPassing(userAccount))
                    return true;
            }

            return false;
        }
    }
}