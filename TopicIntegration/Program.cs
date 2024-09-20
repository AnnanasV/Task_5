Sensor sensor = new Sensor();

sensor.MeasurementUpdated += ShowMeasurementAverage;

sensor.filter = (x => x > 0);
sensor.AddMeasurement(4.9);
sensor.AddMeasurement(-5);
sensor.AddMeasurement(10);

void ShowMeasurementAverage(double measurementAverage) => Console.WriteLine(measurementAverage);