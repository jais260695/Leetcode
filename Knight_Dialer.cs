public class Solution {
    public int KnightDialer(int n) {
        
        int mod = 1000000007;
        List<int>[] adj = new List<int>[10];
        
        for(int i=0;i<10;i++)
        {
            adj[i] = new List<int>();
        }
        
        adj[0].Add(4);
        adj[0].Add(6);
        
        adj[1].Add(6);
        adj[1].Add(8);
        
        adj[2].Add(7);
        adj[2].Add(9);
        
        adj[3].Add(4);
        adj[3].Add(8);
        
        adj[4].Add(0);
        adj[4].Add(3);
        adj[4].Add(9);
        
        adj[6].Add(0);
        adj[6].Add(1);
        adj[6].Add(7);
        
        adj[7].Add(2);
        adj[7].Add(6);
        
        adj[8].Add(1);
        adj[8].Add(3);
        
        adj[9].Add(4);
        adj[9].Add(2);
        
        int[,] dp = new int[10,n+1];
        for(int i=0;i<10;i++)
        {
            dp[i,1] = 1;
        }

        for(int i=2;i<=n;i++)
        {
            for(int j=0;j<10;j++)
            {
                dp[j,i] = 0;
                foreach( var v in adj[j])
                {
                    dp[j,i] = (dp[j,i] + dp[v,i-1])%mod;
                }
            }
        }
        
        int res = 0;
        for(int i=0;i<10;i++)
        {
            res = (res + dp[i,n])%mod;
        }
        return res;
    }
}