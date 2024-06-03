using System;
using System.Collections.Generic;

namespace Fabric_method_Library
{
    public class WebSiteFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
}