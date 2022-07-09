public class Solution {
    Dictionary<string,int> dp = new Dictionary<string,int>();
    int n;
    int DFS(int[] nums, int i, int sum)
    {
        if(i==n)
        {
            if(sum==0)
            {
                return 1;
            }
            return 0;
        }
        string key = i+"|"+sum;
        if(dp.ContainsKey(key)) return dp[key];
        int result = 0;
        result+=DFS(nums,i+1,sum-nums[i]);
        result+=DFS(nums,i+1,sum+nums[i]);
        dp.Add(key,result);
        return result;
    }
    public int FindTargetSumWays(int[] nums, int S) {
        n = nums.Count();
        return DFS(nums,0,S);
    }
}