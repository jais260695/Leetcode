 public class Solution {
    long[,] dp;
    int n;
    public long Solve(int[] nums, int flag, int index)
    {
        if(index==n) return 0;
        
        if(dp[index,flag]!=-1) return dp[index,flag];
        if(flag==0)
        {
            dp[index,flag] =   Math.Max((long)nums[index] + Solve(nums,1,index+1), Solve(nums,flag,index+1));
        }
        else
        {
            dp[index,flag] =   Math.Max(-(long)nums[index] + Solve(nums,0,index+1), Solve(nums,flag,index+1));
        }
        
        return dp[index,flag];
    }
    public long MaxAlternatingSum(int[] nums) {
        n = nums.Count();
        dp = new long[n,2];
        
        for(int i=0;i<n;i++)
        {
            dp[i,0] = -1;
            dp[i,1] = -1;
        }
        
        return Solve(nums,0,0);
    }
}