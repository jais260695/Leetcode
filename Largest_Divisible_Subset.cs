public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        int n = nums.Count();
        int[] par = new int[n];
        int[] dp = new int[n];
        int max = 0;
        int index = -1;
        Array.Sort(nums);
        for(int i=0;i<n;i++)
        {
            dp[i] = 1;
            par[i] = i;
            for(int j=i-1;j>=0;j--)
            {
                if(nums[i]%nums[j]==0)
                {
                   if(dp[i]<dp[j]+1) 
                   {
                       dp[i] = dp[j]+1;
                       par[i] = j;
                   }
                }                    
            }
            if(max<dp[i])
            {
                max = dp[i];
                index = i;
            }
        }
        List<int> res = new List<int>();
        while(par[index]!=index)
        {
            res.Add(nums[index]);
            index = par[index];
        }
        res.Add(nums[index]);
        return res.ToList<int>();
    }
}