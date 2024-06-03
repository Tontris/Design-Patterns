using System;
using System.Collections.Generic;

namespace Fabric_method_Library
{
    public class MobileAppFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}