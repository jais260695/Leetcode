public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int n = arr.Count();
        if(n==0) return 0;
        int[,] dp = new int[n,n];
        

        dp[0,0] = arr[0];
        int sum =arr[0];
        for(int i=1;i<n;i++)
        {
            dp[i,i] = arr[i];
            sum+=arr[i];
            dp[i-1,i] = arr[i-1]+arr[i];
        }
        
        for(int k =2;k<n;k++)
        {
            for(int i =0,j=k;j<n;i++,j++)
            {
                dp[i,j] = dp[i,j-1] + dp[i+1,j] - dp[i+1,j-1];
                if(k%2==0)
                {
                    sum+=dp[i,j];
                }
            }
        }
        return sum;
        
    }
}