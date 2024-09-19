namespace Thermostat
{
    public class Thermostat
    {
        private int temperature;
        delegate void TemperatureChangedEventHandler(int temperature);
        event TemperatureChangedEventHandler TemperatureChanged;

        public Thermostat()
        {
            TemperatureChanged += ShowTemperature;
        }

        private void OnTemperatureChanged(int temperature)
        {
            TemperatureChanged?.Invoke(temperature);
        }

        public void ChangeTemperature(int temperature)
        {
            this.temperature = temperature;
            OnTemperatureChanged(temperature);
        }

        public void ShowTemperature(int temperature)
        {
            Console.WriteLine("Temperature is " + temperature);
        }
    }
}