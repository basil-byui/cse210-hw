
using System;

public class Running : Activity
{
    private double DistanceKm { get; set; } // Distance in kilometers

    public Running(DateTime date, int durationMinutes, double distanceKm) 
        : base(date, durationMinutes)
    {
        DistanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return DistanceKm;
    }

    public override double GetSpeed()
    {
        return (DistanceKm / DurationMinutes) * 60; // Calculates speed in kph
    }

    public override double GetPace()
    {
        return DurationMinutes / DistanceKm; // Calculates pace in minutes per km
    }
}