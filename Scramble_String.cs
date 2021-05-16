public class Solution {
    public Dictionary<string,bool> dp = new Dictionary<string,bool>();
    public bool IsScramble(string s1, string s2) {
        if(s1==s2) return true;
        if(s1.Length != s2.Length)
        {
            return false;
        }
        string t = s1+"-"+s2;
        if(dp.ContainsKey(t)) return dp[t];
       
        int n = s1.Length;
        for(int i=1;i<n;i++)
        {
            if( (IsScramble(s1.Substring(0,i), s2.Substring(0,i)) && IsScramble(s1.Substring(i), s2.Substring(i))) ||  (IsScramble(s1.Substring(0,i),s2.Substring(n-i)) && IsScramble(s1.Substring(i), s2.Substring(0,n-i))) )
            {
                dp.Add(t,true);
                return true;
            }
        }
        dp.Add(t,false);
        return false;
    }
}