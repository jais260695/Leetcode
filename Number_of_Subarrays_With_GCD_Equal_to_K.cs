public class Solution {
    int GCD(int a, int b)
    {
        if (a == b)
            return a;
        if(a>=b) return GCD(a-b,b);
        return GCD(a, b-a);
    }
    public int SubarrayGCD(int[] nums, int k) {
        int n = nums.Count();
        int result = 0;
        int[] dp = new int[n];
        int i = 0;
        for(i=0;i<n;i++)
        {
            
            dp[i] = nums[i];
            if(dp[i]==k)
            {
                result++;
            }
        }
        
        i=n-1;
        while(i>0)
        {
            for(int j=0;j<i;j++)
            {
                dp[j] = GCD(dp[j],dp[j+1]);
                if(dp[j]==k)
                {
                    result++;
                }
            } 
            i--;
        }
        return result;
    }
}