namespace HNGx
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        public string DayOfWeek { get; set; }
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}