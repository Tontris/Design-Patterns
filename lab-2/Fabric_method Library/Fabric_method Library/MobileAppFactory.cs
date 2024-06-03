using System;
using System.Collections.Generic;

namespace Fabric_method_Library
{
    public class MobileAppFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            // Тут можна реалізувати логіку створення підписки через мобільний додаток
            return new EducationalSubscription();
        }
    }
}
