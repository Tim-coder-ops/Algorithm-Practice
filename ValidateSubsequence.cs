/*Given two non empty arrays of integers, write
a function that determines whether the second
array is a subsequence of the first.
*/

using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		
		if(sequence.Count > array.Count) return false;
		
		bool isSequence = false;
		int start = 0;
		
		for(int i = 0; i < sequence.Count; i++)
		{
			isSequence = false;
			
			for(int j = start; j < array.Count; j++)
			{
				if(sequence[i] == array[j]) 
				{
					isSequence = true;
					start = j +1;
					break;
				}
			}
			
			if (isSequence == false) return false; 
		}
		return true;
	}
}
