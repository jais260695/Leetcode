public class Solution {
    public int[] dp;
    public int JumpUtil(int i, int[] nums, int n)
    {
        if(i==n-1)
        {
            return 0;
        }
        
        if(dp[i]!=100000) return dp[i]; 
        
        for(int j=1;j<=nums[i] && (i+j)<n;j++){  
                dp[i] = Math.Min(1+JumpUtil(i+j,nums,n),dp[i]);
        }
        return dp[i];
    }
    public int Jump(int[] nums) {
        int n = nums.Count();
        dp = new int[n];
        for(int i=0;i<n;i++)
        {
            dp[i] = 100000;
        }
        int ans = JumpUtil(0, nums, n);
        return ans<100000?ans:0;
    }
}