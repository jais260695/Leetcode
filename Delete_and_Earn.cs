public class Solution {
    public int DeleteAndEarn(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int n = nums.Count();
        if(n==1) return nums[0];
        List<int> list = new List<int>();
        for(int i=0;i<n;i++)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i],0);
                list.Add(nums[i]);
            }
            map[nums[i]]++;
        }
        n = list.Count();
        list.Sort();
        int[] dp = new int[n];
        dp[0] = list[0]*map[list[0]];
        dp[1] = list[1]*map[list[1]];
        if(list[1]!=list[0]+1)
        {
            dp[1]+=dp[0];
        }
        else
        {
            dp[1] = Math.Max(dp[1],dp[0]);
        }
        for(int i=2;i<n;i++)
        {
            dp[i] = list[i]*map[list[i]];
            if(list[i] != list[i-1] + 1)
            {
                dp[i]+=dp[i-1];
            }
            else
            {
                dp[i] = Math.Max(dp[i]+dp[i-2],dp[i-1]);   
            }
        }
        return dp[n-1];
    }
}