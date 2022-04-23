public class Solution {
    public int VideoStitching(int[][] clips, int time) {
        int n = clips.Count();
        
        Array.Sort(clips,(int[] a, int[] b)=>{
            return a[0]-b[0];
        });
        
        int[] dp = new int[time+1];
        
        for(int i=0;i<=time;i++)
        {
            dp[i] = 101;
        }
        
        dp[0] = 0;
        
        for(int i=0;i<n;i++)
        {
            if(clips[i][0] > time) break;
            for(int j=clips[i][0];j<=Math.Min(clips[i][1],time);j++)
            {
                dp[j] = Math.Min(dp[j],1+dp[clips[i][0]]);
            }
        }
        
        return dp[time]==101 ? -1 : dp[time];
    }
}