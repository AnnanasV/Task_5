namespace Sorting
{
    public class Sorting
    {
        public static Action<int[]> ShowEvenNumbers = (int[] numbers) =>
        {
            Console.WriteLine("Even numbers:");
            foreach (var n in numbers)
            {
                if(n % 2 == 0) Console.WriteLine(n);
            }
        };

        public static Action<int[], int> ShowMoreNumbers = (int[] numbers, int number) =>
        {
            foreach (var n in numbers)
            {
                if(n > number) Console.WriteLine(n + " is more than " + number);
            }
        };
    }
}