public class Solution {
    int mod = 1000000007;
    Dictionary<string,int> dp = new Dictionary<string,int>();
    public int NumberOfWays(int startPos, int endPos, int k) {
        if(k==0)
        {
            if(startPos==endPos) return 1;
            return 0;
        }
        
        string key = startPos + "-" + k;
        if(dp.ContainsKey(key)) return dp[key];
        int result = 0;
        
        result = (result + NumberOfWays(startPos+1,endPos,k-1))%mod;
        result = (result + NumberOfWays(startPos-1,endPos,k-1))%mod;

        dp.Add(key,result);
        return dp[key];
    }
}