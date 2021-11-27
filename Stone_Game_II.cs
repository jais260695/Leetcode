public class Solution {
    
    int[,] dp; 
    int[] prefixSum;
    
    public int util(int[] piles, int index, int M,int n)
    {
        if(index>=n) return 0;
        
        if(dp[index,M]!=0) return dp[index,M];
        
        int res = 0;
        int m = 1;
        for(int x=index; x<n && x<(index+2*M); x++)
        {
            res = Math.Max(res,(prefixSum[n]-prefixSum[index])-util(piles,x+1,Math.Max(M,m),n));
            m++;
        }
        
        return dp[index,M] = res;
    }
    
    public int StoneGameII(int[] piles) {
        int n = piles.Count();
        if(n==1) return piles[0];
        dp = new int[n,n];
        prefixSum = new int[n+1];
        prefixSum[0] = 0;
        for(int i=0;i<n;i++)
        {
            prefixSum[i+1] = prefixSum[i] + piles[i];
        }
        return util(piles,0,1,n);
    }
}