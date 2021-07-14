public class Solution {
    
    public int[,] dp;
    
    public int IsInterleaveUtil(string s1, string s2, string s3, int i, int j) {
        
        if(s1 == "")
        {
            return s3 == s2 ? 1: 0;
        }
        
        if(s2 == "")
        {
            return s3 == s1 ? 1: 0;
        }
        
        
        if(dp[i,j]!=0)
        {
            return dp[i,j];
        }
        
        if(s3[0] == s1[0] )
        {
            if(
                IsInterleaveUtil( 
                    s1.Length == 1 ? "" : s1.Substring(1),
                    s2, 
                    s3.Length == 1 ? "" : s3.Substring(1),
                    i+1,
                    j
               ) == 1 
            )
            {
                return dp[i,j] = 1;
            }
        }
        
        if(s3[0] == s2[0])
        {
            if(
                IsInterleaveUtil( 
                    s1,
                    s2.Length == 1 ? "" : s2.Substring(1),
                    s3.Length == 1 ? "" : s3.Substring(1),
                    i,
                    j+1
               ) == 1 
            )
            {
                return dp[i,j] = 1;
            }
        }
        
        return dp[i,j] = 2;
    }
    
    public bool IsInterleave(string s1, string s2, string s3) {        
        int n1 = s1.Length;
        int n2 = s2.Length;
        
        if(n1 + n2 != s3.Length) return false;
        
        dp = new int[n1, n2];
        
        return IsInterleaveUtil(s1, s2, s3, 0, 0) == 1;
    }
}