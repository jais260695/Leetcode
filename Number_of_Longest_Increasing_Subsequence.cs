public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        int n = nums.Count();
        int[] dp = new int[n];
        int[] dp2 = new int[n];
        for(int i=0;i<n;i++)
        {
            dp[i] = 1;
        }
        
        int result = 1;
        dp2[0] = 1;
        int gMax = 1;
        for(int i=1;i<n;i++)
        {
            int max = 1;
            int count = 1;
            for(int j=i-1;j>=0;j--)
            {
                if(nums[j]<nums[i])
                {
                    if(dp[i]<=dp[j]+1)
                    {
                        dp[i] = dp[j] + 1;
                        if(dp[i]>max)
                        {
                            max = dp[i];
                            count=dp2[j];
                        }
                        else if(dp[i]==max)
                        {
                            count+=dp2[j];
                        }
                    }
                }
            }
            dp2[i] = count;
            if(gMax<dp[i])
            {
                gMax = dp[i];
                result = dp2[i]; 
            }
            else if(gMax==dp[i])
            {
                result+=dp2[i];
            }
        }

        
        return result;
    }
}