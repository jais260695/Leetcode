public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int n = nums.Count();
        int[] dp = new int[2];
        int result = 0;
        for(int i = 0;i<n-2;i++)
        {
            if(nums[i+1]-nums[i]==nums[i+2]-nums[i+1])
            {
                dp[1] = 1 + dp[0];
                result+=dp[1];
            }
            else
            {
                dp[1] = 0;
            }
            dp[0] = dp[1];
        }
        return result;
    }
}