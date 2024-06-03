using System;

namespace Fabric_method_Library
{
    public class ManagerCallFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}