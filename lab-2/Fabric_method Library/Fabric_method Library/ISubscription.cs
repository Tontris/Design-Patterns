namespace Fabric_method_Library
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinPeriod { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
    }
}