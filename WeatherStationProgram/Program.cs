using System;

public class WeatherStationProgram
{
    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherStation);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);

        weatherStation.SetMeasurements(30, 65, 30.4f);
        weatherStation.SetMeasurements(28, 70, 29.2f);
        weatherStation.SetMeasurements(26, 90, 29.2f);
    }
}
