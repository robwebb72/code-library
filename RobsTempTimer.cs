// a simple little static class, used for timing how long a process may take with calls to Start(), End() and Diff()
public static class RobsTempTimer
{
    private static DateTime _startTime;
    private static DateTime _endTime;
    
    public static void Start() => _startTime = DateTime.Now;
    public static void End() => _endTime = DateTime.Now;

    public static double Diff()
    {
        var tempDate = _startTime;
        _startTime = DateTime.Now;
        return (DateTime.Now - tempDate).TotalSeconds;
    }
}
