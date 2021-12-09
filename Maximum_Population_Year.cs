public class Solution {
    public int MaximumPopulation(int[][] logs) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int n = logs.Count();
        int res = 2051;
        int max = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=logs[i][0];j<logs[i][1];j++)
            {
                if(!dict.ContainsKey(j))
                {
                    dict.Add(j,0);
                }
                dict[j]++;
                if(max<dict[j] )
                {
                    max = dict[j];
                    res = j;
                }
                else if(max == dict[j] && res>j)
                {
                    res = j;
                }
            }
        }
        return res;
    }
}