namespace Thermostat
{
    public class Thermostat
    {
        private int temperature;
        delegate void TemperatureChangedEventHandler();
        event TemperatureChangedEventHandler TemperatureChanged;

        public Thermostat()
        {
            TemperatureChanged += ShowTemperature;
        }

        private void OnTemperatureChanged()
        {
            TemperatureChanged?.Invoke();
        }

        public void ChangeTemperature(int temperature)
        {
            this.temperature = temperature;
            OnTemperatureChanged();
        }

        public void ShowTemperature()
        {
            Console.WriteLine("Temperature is " + temperature);
        }
    }
}