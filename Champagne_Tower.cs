public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        if(poured==0) return 0;
        double[,] dp = new double[query_row+1,query_row+1];
        dp[0,0] = poured;
        for(int k=1;k<=query_row;k++)
        {
            int flag = 0;
            for(int i=k,j=0;i>=0;j++,i--)
            {
                if(i-1>=0 && dp[i-1,j]>1)
                    dp[i,j]  += (dp[i-1,j]-1)/2;
                if(j-1>=0 && dp[i,j-1]>1)
                    dp[i,j]  += (dp[i,j-1]-1)/2;
                if(dp[i,j]>1) flag = 1;
            }
            if(flag==0) break;
        }
        return  dp[query_row-query_glass,query_glass]>=1 ? 1 : dp[query_row-query_glass,query_glass];
    }
}