public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Count();
        if(n==0) return 0;
        int[] dp = new int[n];
        dp[0] = 1;
        for(int i=1;i<n;i++)
        {
            dp[i]=1;
            for(int j=i-1;j>=0;j--)
            {
                
                if(nums[i]>nums[j] && dp[i]<=dp[j])
                {
                    dp[i] = dp[j]+1;
                }
            }
        }
        return dp.Max();
    }
}