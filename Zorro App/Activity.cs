using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Zorro_App;

public class Activity
{
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public string? Location { get; set; }
    public double Miles { get; set; }
    public double Elevation { get; set; }
    public double Minutes { get; set; }
    public double Pace { get; set; }

    public Activity(string type, DateTime date, string location, double miles, double minutes, double elevation, double pace)
    {
        Type = type;
        Location = location;
        Date = date;
        Miles = miles;
        Location = location;
        Minutes = minutes;
        Elevation = elevation;
        Pace = pace;
    }
    
    public override string ToString()
    {
        return $"{Date:MM-dd-yyyy}: {Type} at {Location}: {Miles} miles, {Elevation}ft elevation, {Pace:F2} min/mile";
    }
    
    
}