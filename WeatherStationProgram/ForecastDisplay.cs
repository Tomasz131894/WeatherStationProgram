using System;

public class ForecastDisplay : IObserver
{
    private float currentPressure = 29.92f;
    private float lastPressure;
    private ISubject weatherStation;

    public ForecastDisplay(ISubject weatherStation)
    {
        this.weatherStation = weatherStation;
        weatherStation.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        lastPressure = currentPressure;
        currentPressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        if (currentPressure > lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (currentPressure == lastPressure)
        {
            Console.WriteLine("More of the same");
        }
        else if (currentPressure < lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}
