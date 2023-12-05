namespace LLP.Reporting.Api.CampaignSummaries;

public static class RobsTempTimer
{
    private static DateTime _startTime;
    private static DateTime _endTime;
    
    public static void Start() => _startTime = DateTime.Now;
    public static void End() => _endTime = DateTime.Now;

    public static double Diff()
    {
        var x = _startTime;
        _startTime = DateTime.Now;
        return (DateTime.Now - x).TotalSeconds;
    }
}
