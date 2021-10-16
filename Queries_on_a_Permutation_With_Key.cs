public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        int n = queries.Count();
        int[] ans = new int[n];
        List<int> list = new List<int>();
        for(int i=1;i<=m;i++)
        {
            list.Add(i);
        }
        
        for(int i=0;i<n;i++)
        {
            int index = list.IndexOf(queries[i]);
            list.RemoveAt(index);
            list.Insert(0,queries[i]);
            ans[i] = index;
        }
        return ans;
    }
}