public class Solution {
    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        int n1 = nums1.Count();
        int n2 = nums2.Count();
        
        int[,] dp = new int[n1+1,n2+1];
        
        dp[0,0] = 0;
        
        for(int i=1;i<=n2;i++)
        {
            for(int j=1;j<=n1;j++)
            {
                if(nums2[i-1]==nums1[j-1])
                {
                    dp[j,i] = 1 + dp[j-1,i-1];
                }
                else
                {
                    dp[j,i] = Math.Max(dp[j,i-1],dp[j-1,i]);
                }
            }
        }
        return dp[n1,n2];
    }
}