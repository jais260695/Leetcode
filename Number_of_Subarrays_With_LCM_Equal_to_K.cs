public class Solution {
    public int GCD(int a, int b)
    {
        if(a==0) return b;      
        if(a>=b) return GCD(a-b,b);
        else return GCD(b-a,a);
    }
    public int SubarrayLCM(int[] nums, int k) {
        int n = nums.Count();
        int[,] dp = new int[n,n];
        
        int result = 0;
        
        int l = 0,r=0;
        
        for(int i=0;i<n-1;i++)
        {
            if(nums[i]==k)
            {
                result++;
                dp[i,i] = nums[i];
            }
            
            int res = ((nums[i]*nums[i+1])/GCD(nums[i],nums[i+1]));
            if(res==k)
            {
                dp[i,i+1] = res;
                result++;
            }
        }
        
        if(nums[n-1]==k)
        {
            result++;
            dp[n-1,n-1] = nums[n-1];
        }
        
        for(int t=2;t<n;t++)
        {
            for(int i=0,j=t;j<n;i++,j++)
            {
                
            bool flag = false;
                
                int res1 = ((dp[i,j-1]*nums[j])/GCD(dp[i,j-1],nums[j]));
                    if(res1==k)
                    {
                        
                    dp[i,j] = res1;
                    result++;
                        flag = true;
                    }
                
                
                if(flag == false)
                {
                    
                    int res2 = ((dp[i+1,j]*nums[i])/GCD(dp[i+1,j],nums[i]));
                    if(res2==k)
                    {
                        
                    dp[i,j] = res2;
                    result++;
                    }
                }
            }
        }
        
        return result;
    }
}