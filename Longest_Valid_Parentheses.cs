public class Solution {
    public int LongestValidParentheses(string str) {
        if(str=="") return 0;
        int n = str.Length;
        int[] dp = new int[n];
        dp[0] = 0;
        int result = 0;
        for(int i=1;i<n;i++)
        {
            if(str[i]==')')
            {
                if(str[i-1]=='(')
                {
                    dp[i] = 2 + (i-2 >= 0 ? dp[i-2] : 0);
                }
                else if( i-dp[i-1]-1>=0 &&  str[i-dp[i-1]-1]=='(')
                {
                    dp[i] = dp[i-1] + 2 + (i-dp[i-1]-2 >=0 ? dp[i-dp[i-1]-2] : 0);
                }
            }
            result = Math.Max(result,dp[i]);
        }
        return result;
    }
}