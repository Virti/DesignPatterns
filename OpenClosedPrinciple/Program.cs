using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * To better understand this example, I'd suggest reading BadPolicyChecker
             * source code first.
             */
            var passwordRetentionPolicy = new OneMonthPasswordRetentionPolicy();
            var accountActivePolicy = new ActiveForAtLeastMonthPolicy();

            var tenDaysAgo = DateTime.UtcNow.AddDays(-10);
            bool policyCheckResult;

            UserAccount userAccount = new UserAccount()
            {
                UtcActivatedAt = tenDaysAgo,
                UtcLastPasswordChange = tenDaysAgo
            };

            NicePolicyChecker npc = new NicePolicyChecker();
            BadPolicyChecker bpc = new BadPolicyChecker();

            policyCheckResult = bpc.MeetsAllPolicies(userAccount, 
                new object[] {passwordRetentionPolicy, accountActivePolicy});
            Console.WriteLine($"First policy check result: {policyCheckResult}");

            policyCheckResult = npc.MeetsAllPolicies(userAccount,
                new IPolicy<UserAccount>[] {accountActivePolicy, passwordRetentionPolicy});
            Console.WriteLine($"Second policy check result: {policyCheckResult}");

            Console.WriteLine($"Press any key to close this window.");
            Console.ReadKey();
        }
    }
}
