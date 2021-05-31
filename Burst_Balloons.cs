public class Solution {
    public int MaxCoins(int[] nums) {
        int n = nums.Count();
        if(n==0) return 0;
        if(n==1) return nums[0];
        int[,] dp = new int[n,n];
        
        dp[0,0] = nums[0]*nums[1];
        for(int i=1;i<n-1;i++)
        {
            dp[i,i] = nums[i-1]*nums[i]*nums[i+1];
        }
        dp[n-1,n-1] = nums[n-1]*nums[n-2];
        
        for(int k=1;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                int left = 1;
                if(i-1>=0)
                {
                    left = nums[i-1];
                }

                int right = 1;
                if(j+1<n)
                {
                    right = nums[j+1];
                }
                
                dp[i,j] = left*nums[i]*right;
                
                if(i+1<n)
                    dp[i,j]+=dp[i+1,j];
                
                for(int mid = i+1; mid<j;mid++)
                {
                    dp[i,j] = Math.Max(dp[i,mid-1]+(left*nums[mid]*right)+dp[mid+1,j],dp[i,j]);
                }
                
                dp[i,j] = Math.Max( (j-1>=0?dp[i,j-1]:0)+(left*nums[j]*right),dp[i,j]);
            }
        }
        
        return dp[0,n-1];
        
    }
}