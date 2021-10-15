public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int n = accounts.Count();
        int m = accounts[0].Count();
        int ans = 0;
        for(int i=0;i<n;i++)
        {
            int sum = 0;
            for(int j=0;j<m;j++)
            {
                sum+=accounts[i][j];
            }
            ans = Math.Max(ans,sum);
        }
        return ans;
    }
}