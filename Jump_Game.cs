public class Solution {
    public int[] dp;
    public bool CanJumpUtil(int i,int[] arr,int n){
        if(i==n-1)
        {
            return true;
        }
        if(dp[i]!=0)
        {
            return dp[i]==-1? false : true;
        }
        for(int j=1;j<=arr[i] && (i+j)<n;j++)
        {
            if(CanJumpUtil(i+j,arr,n))
            {
                dp[i] = 1;
                return true;
            }
        }
        dp[i] = -1;
        return false;
    }
    public bool CanJump(int[] arr) {
        int n = arr.Count();
        dp = new int[n];
        return CanJumpUtil(0,arr,n);
    }
}