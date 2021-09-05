public class Solution {
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        Dictionary<int, HashSet<int>> dict = new Dictionary<int,HashSet<int>>();
        int n = logs.Count();
        for(int i =0;i<n;i++)
        {
            if(!dict.ContainsKey(logs[i][0]))
            {
                dict.Add(logs[i][0],new HashSet<int>());
            }
            dict[logs[i][0]].Add(logs[i][1]);
        }
        int[] ans = new int[k];
        
        foreach(KeyValuePair<int,HashSet<int>> kvp in dict)
        {
            ans[kvp.Value.Count()-1]++;
        }
        return ans;
    }
}