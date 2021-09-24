public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n,n];
        string str ="";
        for(int i = 0;i<n;i++)
        {
            dp[i,i] = true;
            str = s.Substring(i,1);;
        }
        
        for(int i = 0;i<n-1;i++)
        {
            if(s[i]==s[i+1])
            {
                dp[i,i+1] = true;
                str = s.Substring(i,2);
            }
        }
        
        
        for(int k  = 2; k < n ; k++)
        {
            for(int i = 0, j=k;j<n;j++,i++)
            {
                if(s[i]==s[j])
                {
                    if(dp[i+1,j-1]==true)
                    {
                        dp[i,j] = true;
                        str = s.Substring(i,j-i+1);
                    }
                }
            }
        }
        return str;
    }
}