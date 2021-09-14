public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length;
        int[] dp = new int[n];
        
        if(s[0]!='0')
        {
            if(n==1) return 1;
            dp[0] = 1;
            int val1 = Convert.ToInt32(s.Substring(1,1));
            int val2 = Convert.ToInt32(s.Substring(0,2));
            if(val1>=1 && val1<=9)
            {
                dp[1] = dp[0];
            }
            if(val2<=26)
            {
                if(val2>=10)
                {
                    dp[1] += 1;
                }
            }
        }
        else
        {
            return 0;
        }
        
        
        for(int i=2;i<n;i++)
        {
            int val1 = Convert.ToInt32(s.Substring(i,1));
            int val2 = Convert.ToInt32(s.Substring(i-1,2));
            
            if(val1>=1 && val1<=9)
            {
                dp[i] = dp[i-1];
            }
            if(val2>=10 && val2<=26)
            {
                dp[i]+=dp[i-2];
            }
        }
        
        return dp[n-1];
    }
}