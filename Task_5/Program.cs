using static IntExtension.Extensions;
Thermostat.Thermostat thermostat = new Thermostat.Thermostat();
thermostat.ChangeTemperature(15);
thermostat.ChangeTemperature(17);

var numbers1 = new int[] { 1, 4, 2, 6, 7, 7 };
var numbers2 = new int[] { 1, 2, 3, 4, 5 };
Sorting.Sorting.ShowEvenNumbers(numbers1);
Sorting.Sorting.ShowMoreNumbers(numbers1, 5);

Console.WriteLine("Average is " + numbers1.Average());
Console.WriteLine("Average is " + numbers2.Average());