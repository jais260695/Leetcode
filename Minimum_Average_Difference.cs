public class Solution {
    public int MinimumAverageDifference(int[] nums) {
        int n = nums.Count();
        if(n==1)  return 0;
        long[] prefrixSum = new long[n+1];

        for(int i=0;i<n;i++)
        {
            prefrixSum[i+1]=prefrixSum[i] + (long)nums[i];
        }

        long minimumDifference = long.MaxValue;
        int ans = -1;
        for(int i=1;i<n;i++)
        {
            long diff = Math.Abs((long)(prefrixSum[i]/i) - (long)((prefrixSum[n]-prefrixSum[i])/(n-i)));
            if(diff<minimumDifference)
            {
                minimumDifference = diff;
                ans = i-1;
            }
        }
        if(minimumDifference>Math.Abs((long)(prefrixSum[n]/n)))
        {
            ans = n-1;
        }

        return ans;
    }
}