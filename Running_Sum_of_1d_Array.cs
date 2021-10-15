public class Solution {
    public int[] RunningSum(int[] nums) {
        int n = nums.Count();
        for(int i=1;i<n;i++)
        {
            nums[i] = nums[i]+nums[i-1];
        }
        return nums;
    }
}