public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Count();
        if(n==1 || n==2) return true;
        int[,] dp = new int[n,n];
        for(int i=0;i<n-1;i++)
        {
            dp[i,i] = nums[i];
            dp[i,i+1] = Math.Max(nums[i],nums[i+1]);
        }
        dp[n-1,n-1] = nums[n-1];
        
        for(int k = 2;k<n;k++)
        {
            for(int j=k,i=0;j<n;j++,i++)
            {
                dp[i,j] = Math.Max(
                            nums[j] + Math.Min(dp[i+1,j-1],dp[i,j-2]),
                            nums[i] + Math.Min(dp[i+2,j],dp[i+1,j-1])
                          );
            }
        }
        
        return dp[0,n-1]>= Math.Min(dp[0,n-2], dp[1,n-1]);
    }
}