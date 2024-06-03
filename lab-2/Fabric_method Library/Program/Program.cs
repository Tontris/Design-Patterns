using System;
using System.Collections.Generic;
using Fabric_method_Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubscriptionFactory websiteFactory = new WebSiteFactory();
            ISubscription websiteSubscription = websiteFactory.CreateSubscription();
            DisplaySubscriptionDetails(websiteSubscription);

            ISubscriptionFactory mobileAppFactory = new MobileAppFactory();
            ISubscription mobileAppSubscription = mobileAppFactory.CreateSubscription();
            DisplaySubscriptionDetails(mobileAppSubscription);

            ISubscriptionFactory managerCallFactory = new ManagerCallFactory();
            ISubscription managerCallSubscription = managerCallFactory.CreateSubscription();
            DisplaySubscriptionDetails(managerCallSubscription);
        }

        static void DisplaySubscriptionDetails(ISubscription subscription)
        {
            Console.WriteLine($"Monthly Fee: {subscription.MonthlyFee}");
            Console.WriteLine($"Minimum Period: {subscription.MinPeriod} months");
            Console.WriteLine("Channels:");
            foreach (var channel in subscription.Channels)
            {
                Console.WriteLine($"- {channel}");
            }
            Console.WriteLine("Features:");
            foreach (var feature in subscription.Features)
            {
                Console.WriteLine($"- {feature}");
            }
            Console.WriteLine();
        }
    }
}
