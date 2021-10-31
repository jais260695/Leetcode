public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        int n = mat.Count();
        int m = mat[0].Count();
        for(int i=0;i<n;i++)
        {
            int l = 0;
            int r = m-1;
            while(l<=r)
            {
                int mid = l+(r-l)/2;
                if(mat[i][mid]==0)
                {
                    r = mid-1;
                }
                else
                {
                    l = mid+1;
                }
            }
            dict.Add(i,r+1);
        }
        int[] res = new int[k];
        int z = 0;
        foreach(KeyValuePair<int,int> kv in dict.OrderBy(d=>d.Value))
        {
           res[z++] = kv.Key;
           if(z==k) break;
        }
        return res;
    }
}