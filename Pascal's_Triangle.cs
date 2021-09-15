public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> dp = new List<int>();
        dp.Add(1);
        result.Add(dp);
        for(int i = 1;i<numRows;i++)
        {
            List<int> temp = new List<int>();
            temp.Add(dp[0]);
            for(int j=0;j<i-1;j++)
            {
                temp.Add(dp[j]+dp[j+1]);
            }
            temp.Add(dp[i-1]);
            result.Add(temp);
            dp = temp;
        }
        
        return result.ToList<IList<int>>();
    }
}