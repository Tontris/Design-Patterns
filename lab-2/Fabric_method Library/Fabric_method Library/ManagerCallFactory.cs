using System;

namespace Fabric_method_Library
{
    public class ManagerCallFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            // Тут можна реалізувати логіку створення підписки через дзвінок менеджеру
            return new PremiumSubscription();
        }
    }
}
