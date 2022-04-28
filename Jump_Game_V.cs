public class Solution {
    int[] dp;
    int n;
    int d;
    public int Solve(int[] arr, int index)
    {
        if(index<0 || index>=n) 
        {
            return 0;
        }
        
        if(dp[index]!=0) return dp[index];
        
        int l = index - d;
        int r = index + d;
        
        int result = 1;
        
        for(int i = index-1;i>=l && i>=0;i--)
        {
            if(arr[i]>=arr[index]) break;
            result = Math.Max(result,1+Solve(arr,i));
        }
        
        for(int i = index+1;i<=r && i<n;i++)
        {
            if(arr[i]>=arr[index]) break;
            result = Math.Max(result,1+Solve(arr,i));
        }
        
        return dp[index] = result;
    }
    public int MaxJumps(int[] arr, int d) {
        n = arr.Count();
        dp = new int[n];
        this.d = d;
        
        int result = 1;
        for(int i=0;i<n;i++)
        {
            result = Math.Max(result,Solve(arr,i));
        }
        
        return result;
    }
}