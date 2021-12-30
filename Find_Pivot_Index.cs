public class Solution {
    public int PivotIndex(int[] nums) {
        int n = nums.Count();
        int[] dp = new int[n+2];
        dp[0] = 0;
        for(int i=1;i<=n;i++)
        {
            dp[i] = nums[i-1] + dp[i-1];
        }
        dp[n+1] = 0;
        
        for(int i=1;i<=n;i++)
        {
            if(dp[i-1]==dp[n]-dp[i])
                return i-1;
        }
        return -1;
    }
}