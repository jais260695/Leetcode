public class Solution {
    public int NumTrees(int n) {
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i =2;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                int left = j-1;
                int right = i-j;
                dp[i]+=(dp[left]*dp[right]);
            }            
        }
        return dp[n];
    }
}