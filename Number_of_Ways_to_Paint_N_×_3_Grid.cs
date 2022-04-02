public class Solution {
    public bool HaveCommon(string s1,string s2)
    {
        for(int i=0;i<3;i++)
        {
            if(s1[i]==s2[i]) return true;
        }
        return false;
    }
    public int NumOfWays(int n) {
        int[,] dp = new int[n,12];
        
        int mod = 1000000007;
        
        string[] states = new string[12];
        
        states[0] = "121";
        states[1] = "131";
        states[2] = "123";
        states[3] = "132";
        states[4] = "212";
        states[5] = "232";
        states[6] = "213";
        states[7] = "231";
        states[8] = "313";
        states[9] = "323";
        states[10] = "321";
        states[11] = "312";
        
        for(int i=0;i<12;i++)
        {
            dp[0,i] = 1;
        }
        
        for(int i = 1;i<n;i++)
        {
            for(int j=0;j<12;j++)
            {
                for(int k=0;k<12;k++)
                {
                    if(HaveCommon(states[j],states[k])) continue;
                    dp[i,j] = (dp[i,j] + dp[i-1,k])%mod;
                }
            }
        }
        
        int result = 0;
        for(int i=0;i<12;i++)
        {
            result = (result + dp[n-1,i])%mod;
        }
        return result;
    }
}