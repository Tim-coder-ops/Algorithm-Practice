//Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

//Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if(nums.Length == 0) return 0;
        int count = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[count] != nums[i]){
                count++;
                nums[count] = nums[i];
            }
            
        }
        
        return count + 1;
    }
}