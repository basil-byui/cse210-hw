
using System;

public class Cycling : Activity
{
    private double SpeedKph { get; set; } // Speed in kilometers per hour

    public Cycling(DateTime date, int durationMinutes, double speedKph) 
        : base(date, durationMinutes)
    {
        SpeedKph = speedKph;
    }

    public override double GetDistance()
    {
        return (SpeedKph * DurationMinutes) / 60; // Calculates distance in km
    }

    public override double GetSpeed()
    {
        return SpeedKph;
    }

    public override double GetPace()
    {
        return 60 / SpeedKph; // Calculates pace as minutes per km
    }
}