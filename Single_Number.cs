public class Solution {
    public int SingleNumber(int[] nums) {
        int n = nums.Count();
        int result = nums[0];
        
        for(int i=1;i<n;i++)
        {
            result ^=nums[i];
        }
        return result;
    }
}