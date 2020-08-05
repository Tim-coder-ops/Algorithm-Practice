using System;

namespace UniqueNumAlgorithm
{
    class UniqueNumberAlgorithm
    {
        static int FindNum(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for(int j = 0; j < array.Length; j++)
                {
                    if(i != j)
                    {
                        if (array[i] == array[j]) count++; 
                    }
                }

                if (count == 0) return array[i];
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 2, 3, 3 };

            Console.WriteLine(FindNum(array));
        }
    }
}
