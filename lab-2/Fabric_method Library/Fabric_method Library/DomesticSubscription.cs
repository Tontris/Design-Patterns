namespace Fabric_method_Library
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee { get { return 10.0m; } }
        public int MinPeriod { get { return 1; } }
        public List<string> Channels { get { return new List<string> { "Basic Channels" }; } }
        public List<string> Features { get { return new List<string> { "4k Quality" }; } }
    }
}