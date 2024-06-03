using System;
using System.Collections.Generic;

namespace Fabric_method_Library
{
    public class WebSiteFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            // Тут можна реалізувати логіку створення підписки через веб-сайт
            return new DomesticSubscription();
        }
    }
}
