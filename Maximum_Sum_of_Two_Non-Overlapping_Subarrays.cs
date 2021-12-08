public class Solution {
    public int Calculate(int[,] dp, int L, int M, int n)
    {
        int max = int.MinValue;
        for(int i = 0,j=L-1;j<n;j++,i++)
        {
            int val = dp[i,j];
           for(int l=0,k = M-1;k<i;l++,k++)
           {
               
               if(max<val+dp[l,k])
               {
                   max = val + dp[l,k];
               }
           }
            
           for(int l=j+1,k = M-1+l;l<n&&k<n;l++,k++)
           {
               if(max<val+dp[l,k])
               {
                   max = val + dp[l,k];
               }
           } 
            
        }
        return max;
    }
    public int MaxSumTwoNoOverlap(int[] arr, int L, int M) {
        //Try with Prefix Sum and Sliding Window method to get better space and time complexity
        int n = arr.Count();
        if(n==0) return 0;
        int[,] dp = new int[n,n];
        dp[0,0] = arr[0];
        for(int i=1;i<n;i++)
        {
            dp[i,i] = arr[i];
            dp[i-1,i] = arr[i-1]+arr[i];
        }
        
        for(int k =2;k<n;k++)
        {
            for(int i =0,j=k;j<n;i++,j++)
            {
                dp[i,j] = dp[i,j-1] + dp[i+1,j] - dp[i+1,j-1];
            }
        }
        if(L>=M)
            return Calculate(dp,L,M,n);
        
        return Calculate(dp,M,L,n);
    }
}