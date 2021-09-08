public class Solution {
    public int Rob(int[] nums) {
        if(nums.Count()==0) return 0;
        if(nums.Count()==1) return nums[0];
        int sum = 0;
        int n = nums.Count();
        int[] dp = new int[n];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[1],nums[0]);
        for(int i=2;i<n;i++)
        {
            dp[i] = Math.Max(nums[i]+dp[i-2],dp[i-1]);         
        }
        return dp[n-1];
    }
}