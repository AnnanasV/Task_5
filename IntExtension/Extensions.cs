namespace IntExtension
{
    public static class Extensions
    {
        public static double Average(this int[] numbers)
        {
            double averageNum = 0;
            foreach (var i in numbers)
            {
                averageNum += i;
            }
            return averageNum / numbers.Length;
        }

        public static double Average(this List<double> numbers)
        {
            double averageNum = 0;
            foreach (var i in numbers)
            {
                averageNum += i;
            }
            return averageNum / numbers.Count;
        }
    }
}