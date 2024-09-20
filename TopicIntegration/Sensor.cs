using static IntExtension.Extensions;
public class Sensor
{
    public event Action<double> MeasurementUpdated;

    public List<double> measurements = new List<double>();
    public double measurementAverage;
    public Func<double, bool> filter;

    public void AddMeasurement(double measurement)
    {
        if (filter(measurement))
            measurements.Add(measurement);
        else return;
        measurementAverage = measurements.Average();
        MeasurementUpdated?.Invoke(measurementAverage);
    }
}
