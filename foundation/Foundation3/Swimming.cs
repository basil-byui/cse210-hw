
using System;

public class Swimming : Activity
{
    private int Laps { get; set; }
    private const double LapDistanceKm = 0.05; // Distance of one lap in kilometers

    public Swimming(DateTime date, int durationMinutes, int laps) 
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapDistanceKm; // Calculates total distance in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60; // Calculates speed in kph
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance(); // Calculates pace as minutes per km
    }
}