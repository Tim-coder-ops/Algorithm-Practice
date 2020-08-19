//Given an array of integers, return indices of the two numbers such that they add up to a specific target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.



public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] result = new int[2];
        
        
        for(int i = 0; i < nums.Length; i++){
            
            for(int j = i+1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }
}