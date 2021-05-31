public class Solution {
    Dictionary<int,bool> dp = new Dictionary<int,bool>();
    
    public bool WinnerSquareGame(int n) {
        if(n==1) return true;
        if(dp.ContainsKey(n)) return dp[n];
        for(int i=1; i*i<=n;i++)
        {
            if(!WinnerSquareGame(n-i*i))
            {
                dp.Add(n,true);
                return true;
            }
        }
        dp.Add(n,false);
        return false;
    }
}