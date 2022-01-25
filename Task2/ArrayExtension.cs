namespace Task2
{
    public static class ArrayExtension
    {
        public static double getAVG(this int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                result += array[i];
            }
            return (double)result / (double)array.Length;
        }

        public static int getMax(this int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }


        public static int getMin(this int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }
        public static int getAmount(this int[] array)
        {
            int amount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                amount += array[i];
            }
            return amount;
        }
    }
}
