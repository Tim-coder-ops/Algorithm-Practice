\*Write a function that takes in an integer (n) and returns the nth Fibonacci number.
*The first two numbers of the Fibonacci sequence are 0 and 1.
*the Fibonacci sequence is defined as the nth number is equal to the sum of the (n-1)th and (n-2)th numbers.
*\
	

public static int GetNthFib(int n) {
		
		if(n == 1) return 0;
		int[] numbers = new int[n];
		numbers[0] =0; numbers[1] =1;
		
		for(int i = 2; i < numbers.Length; i++)
		{
			numbers[i] = numbers[i-1] + numbers[i -2];
		}
		return numbers[n-1];
	}