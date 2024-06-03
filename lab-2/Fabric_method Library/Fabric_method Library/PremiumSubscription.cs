namespace Fabric_method_Library
{
    public class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee { get { return 50.0m; } }
        public int MinPeriod { get { return 6; } }
        public List<string> Channels { get { return new List<string> { "Premium Channels" }; } }
        public List<string> Features { get { return new List<string> { "4K Quality", "Unlimited Devices" }; } }
    }
}