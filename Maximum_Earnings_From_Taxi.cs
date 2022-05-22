public class Solution {
    public long MaxTaxiEarnings(int n, int[][] rides) {
        int m = rides.Count();
        
        Array.Sort(rides,delegate(int[] a, int[] b){
            if(a[1]!=b[1])
                return a[1]-b[1];
            return a[0]-b[0];
        });

        /*for(int i=0;i<m;i++)
        {
            Console.Write("["+rides[i][0]+","+rides[i][1]+","+rides[i][2]+"]");
        }
        Console.WriteLine();*/
        
        
        long[] dp = new long[m];
        
        
        
        dp[0] = (long)rides[0][1] - (long)rides[0][0] + (long)rides[0][2];
        
        long result = dp[0];
        
        for(int i=1;i<m;i++)
        {
            long currCost = (long)rides[i][1] - (long)rides[i][0] + (long)rides[i][2];
            
            dp[i] = Math.Max(dp[i-1],currCost);
            
            int l = 0; 
            int r = i-1;
            long val = rides[i][0];
            
            while(l<=r)
            {
                int mid = l + (r-l)/2;
                if(rides[mid][1]<=val)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            
            
            if(r>=0)
            {
                dp[i] = Math.Max(dp[i],dp[r]+currCost);
            }
            
            
            //Console.WriteLine(i+","+r + " = "+ currCost +","+ dp[i]);
            
            result = Math.Max(result,dp[i]);
        }

        
        return result;
    }
}