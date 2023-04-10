namespace DestopApp.Data;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary
    {
        get
        {
            if (TemperatureF < 10)
                return "Freezing";
            if (TemperatureF < 32)
                return "Bracing";
            if (TemperatureF < 45)
                return "Chilly";
            if (TemperatureF < 65)
                return "Cool";
            if (TemperatureF < 80)
                return "Mild";
            if (TemperatureF < 90)
                return "Warm";
            if (TemperatureF < 95)
                return "Balmy";
            if (TemperatureF < 100)
                return "Hot";
            if (TemperatureF < 105)
                return "Sweltering";
            return "Scorching";
        }
    }
}