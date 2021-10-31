public class Solution {
    public int[] CountBits(int num) {
        int[] dp = new int[num+1];
        dp[0] = 0;
        for(int n =1;n<=num;n++)
        {
            int res = 0;
            dp[n] = (n&1) + dp[n>>1];
        }
       return dp; 
    }
}