public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int ans = 0;
        int n = timeSeries.Count();
        if(n==0) return 0;
        if(n==1) return duration;
        for(int i=0; i<n-1;i++)
        {
            ans+=Math.Min(timeSeries[i+1]-timeSeries[i],duration);
        }
        
        ans+=duration;
        return ans;
    }
}