//Write an algorithm that takes an unsorted array of intergers
// and returns a sorted array.



static int[] SortBucketsOfInts(int[] buckets)
        {
            
            for(int i = 0; i < buckets.Length; i++)
            {
                for(int j = i +1; j < buckets.Length; j++)
                {
                    if( buckets[j] < buckets[i])       
                    {
                        int temp = buckets[j];                          
                        for (int k = j -1; k >= i; k--)
                        {
                            buckets[k + 1] = buckets[k];
                        }

                        buckets[i] = temp;
                    }

                }
            }

            return buckets;
        }




//The random array is 6, 4, 4, 13, 14, 3, 1, 0, 9, 6
//The array sorted is 0, 1, 3, 4, 4, 6, 6, 9, 13, 14