using System;

namespace CountDestinctElements
{
    class ArrayNumberAlgorithms
    {
        //Create a method that returns the count of unique elements in an int array.
        //ex: {8, 6, 7, 5, 3, 0, 9, 8, 6, 7} returns 7

        public static int UniqueNumber(int[] array)
        {
            int count = 0;

            for(int i = 0; i < array.Length; i++)
            {
                int duplicates = 0;

                for(int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        if (array[i] == array[j]) duplicates++;
                    }
                }

                if (duplicates == 0) count++;
            }

            return  count;
        }
        public static int DistinctNumbers(int[] DistinctArray)
        {

            int counter = 0;
            int length = DistinctArray.Length;

            for (int i = 0; i < DistinctArray.Length; i++)
            {
                for (int j = i + 1; j < DistinctArray.Length; j++)
                {
                    if (DistinctArray[i] == DistinctArray[j])
                    {
                        counter++;
                    }
                }
            }
            return length - counter;
        }

        static void Main(string[] args)
        {
            int[] testArray = new int[] { 8, 6, 7, 1, 5, 3, 0, 9, 8, 6, 7 };

            Console.WriteLine($"There are {UniqueNumber(testArray)} unique elements");
            Console.WriteLine($"There are {DistinctNumbers(testArray)} distinct elements");
        }
    }
}
