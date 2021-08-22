public class Solution {
    int[,] prefixSum;
    int[,,] dp;
    int mod = 1000000007;
    public void CalculatePrefixArray(string[] pizza)
    {
        int n = pizza.Length;
        int m = pizza[0].Length;
        prefixSum = new int[n,m];
        if(pizza[0][0]=='A')
        {
            prefixSum[0,0] = 1;
        }
        for(int i = 1;i<n;i++)
        {
            prefixSum[i,0] = prefixSum[i-1,0]%mod;
            if(pizza[i][0]=='A')
            {
                prefixSum[i,0] = (prefixSum[i,0] + 1)%mod;
            }
        } 
        for(int j = 1;j<m;j++)
        {
            prefixSum[0,j] = (prefixSum[0,j] + prefixSum[0,j-1])%mod;
            if(pizza[0][j]=='A')
            {
                prefixSum[0,j] = (prefixSum[0,j] + 1)%mod;
            }
        }      
        for(int i=1;i<n;i++)
        {
            for(int j = 1;j<m;j++)
            {
                prefixSum[i,j] = (prefixSum[i,j-1] + prefixSum[i-1,j])%mod - prefixSum[i-1,j-1];
                if(pizza[i][j]=='A')
                {
                    prefixSum[i,j] = (prefixSum[i,j] + 1)%mod;
                }
            }
        }
    }
    
    public int CountApples(int r1,int c1,int r,int c)
    {
        int totalApples = prefixSum[r,c];
        if(r1-1>=0)
            totalApples-=prefixSum[r1-1,c];
        if(c1-1>=0)
            totalApples-=prefixSum[r,c1-1];
        if(r1-1>=0 && c1-1>=0)
            totalApples=(totalApples + prefixSum[r1-1,c1-1])%mod;
        return totalApples;
    }
    
    
    public int CountWays(int r1, int c1, int k, int r, int c)
    {
        if(k==0)
        {
            return 1;
        }   
        if(dp[r1,c1,k]!=-1) return dp[r1,c1,k]; 
        int result = 0;
        int totalApples = CountApples(r1,c1,r,c);
        for(int i = r1+1;i<=r;i++)
        {
            int temp = CountApples(i,c1,r,c);
            if(temp>0 && temp<totalApples)
            {
                result=(result+CountWays(i,c1,k-1,r,c))%mod;
            }
        }
        for(int j = c1+1;j<=c;j++)
        {
            int temp = CountApples(r1,j,r,c);
            if(temp>0 && temp<totalApples)
            {
                result=(result+CountWays(r1,j,k-1,r,c))%mod;
            }
        }
        return dp[r1,c1,k] = result;
    }
    
    public int Ways(string[] pizza, int k) {
        int n = pizza.Length;
        int m = pizza[0].Length;
        CalculatePrefixArray(pizza);
        dp = new int[n,m,k];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                for(int l=0;l<k;l++)
                {
                    dp[i,j,l] = -1;
                }
            }
        }
        return CountWays(0,0,k-1,n-1,m-1);
    }
}