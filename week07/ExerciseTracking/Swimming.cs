public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Convert laps to kilometers (assuming 50m per lap)
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double hours = GetDuration() / 60.0; // Convert minutes to hours
        return distance / hours; // Speed in km/h
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0) return 0; // Avoid division by zero
        double minutesPerKm = GetDuration() / distance; // Pace in minutes per kilometer
        return minutesPerKm;
    }
}   


