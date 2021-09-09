public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Count()==1) return nums[0];
        
        int max_so_far=0;
        int max_result=-999999;
        for(int i=0;i<nums.Count();i++)
        { 
            if(max_so_far<0)
            {
                max_so_far=0;
            }
            max_so_far+=nums[i];
            if(max_result<max_so_far)
            {
                max_result = max_so_far;
            }
        }
        return max_result;
        
    }
}