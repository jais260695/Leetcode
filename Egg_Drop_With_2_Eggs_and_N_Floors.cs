public class Solution {
    public int TwoEggDrop(int N) {
        int K = 2;
       int[] dp1 = new int[N+1];//for K-1
        int[] dp2 = new int[N+1];//for K
        for(int i=1;i<=N;i++)
        {
            dp1[i] = i;//for K=1
        }
         
        for(int k=2;k<=K;k++)
        {
            int x = 1;
            for(int n=1;n<=N;n++)
            {
                //Binary search can also be used
                while(x<n)
                {
                    if(Math.Max(dp1[x-1],dp2[n-x])<Math.Max(dp1[x],dp2[n-x-1])) break;
                    x++;
                }
                
               dp2[n] = 1 + Math.Max(dp1[x-1],dp2[n-x]);
            }
            dp1 = dp2;
            dp2 = new int[N+1];
        }
        return dp1[N];
    }
}