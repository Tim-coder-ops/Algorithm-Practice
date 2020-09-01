//Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

//I can be placed before V (5) and X (10) to make 4 and 9. 
//X can be placed before L (50) and C (100) to make 40 and 90. 
//C can be placed before D (500) and M (1000) to make 400 and 900.

//Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.




public class Solution {
    public int RomanToInt(string s) {
        
        int num = 0;
        int[] input = new int[s.Length];
        
        for(int i = 0; i < input.Length; i++)
        {
            if(s[i] == 'I') input[i] = 1;
            else if(s[i] == 'V') input[i] = 5;
            else if(s[i] == 'X') input[i] = 10;
            else if(s[i] == 'L') input[i] = 50;
            else if(s[i] == 'C') input[i] = 100;
            else if(s[i] == 'D') input[i] = 500;
            else if(s[i] == 'M') input[i] = 1000;
        }
        
            
            for(int i =0; i < input.Length; i++)
            {
                if(i + 1 < input.Length && input[i] < input[i + 1] )
                {
                    num += input[i +1] - input[i];
                    i++;
                }
                else
                {
                    num += input[i];
                }
                    
            }

        return num;
    }
}