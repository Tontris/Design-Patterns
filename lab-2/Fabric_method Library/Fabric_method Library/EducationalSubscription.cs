namespace Fabric_method_Library
{
    public class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee { get { return 20.0m; } }
        public int MinPeriod { get { return 3; } }
        public List<string> Channels { get { return new List<string> { "Educational Channels" }; } }
        public List<string> Features { get { return new List<string> { "Ad-free", "Offline Viewing" }; } }
    }
}
