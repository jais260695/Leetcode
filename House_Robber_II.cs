public class Solution {
    public int RobUtil(int[] nums, int l, int h) {
        int n = h-l+1;
        if(n==0) return 0;
        if(n==1) return nums[l];
        int[] dp = new int[n];
        dp[0] = nums[l];
        dp[1] = Math.Max(nums[l+1],nums[l]);
        for(int i=2;i<n;i++)
        {
            dp[i] = Math.Max(nums[l+i]+dp[i-2],dp[i-1]);         
        }
        return dp[n-1];
    }
    
    public int Rob(int[] nums) {
        int n = nums.Count();
        if(n==1) return nums[0];
        return Math.Max(RobUtil(nums,0,n-2),RobUtil(nums,1,n-1));
    }
}