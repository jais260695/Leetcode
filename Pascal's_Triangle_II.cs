public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> dp = new List<int>();
        dp.Add(1);
        for(int i = 1;i<=rowIndex;i++)
        {
            List<int> temp = new List<int>();
            temp.Add(dp[0]);
            for(int j=0;j<i-1;j++)
            {
                temp.Add(dp[j]+dp[j+1]);
            }
            temp.Add(dp[i-1]);
            dp = temp;
        }
        
        return dp;
    }
}