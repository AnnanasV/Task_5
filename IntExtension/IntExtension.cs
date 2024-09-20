namespace IntExtension
{
    public static class IntExtension
    {
        public static double Average(this int[] numbers)
        {
            double averageNum = 0;
            foreach (int i in numbers)
            {
                averageNum += i;
            }
            return averageNum / numbers.Length;
        }
    }
}