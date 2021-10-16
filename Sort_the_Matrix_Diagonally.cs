public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        int n = mat.Count();
        int m = mat[0].Count();
        dict.Add(0,new List<int>());
        for(int j= 1;j<m;j++)
        {
            if(!dict.ContainsKey(-j))
            {
                dict.Add(-j,new List<int>());
            }
        }
        
        for(int i= 1;i<n;i++)
        {
            if(!dict.ContainsKey(i))
            {
                dict.Add(i,new List<int>());
            }
        }
        
        for(int i= 0;i<n;i++)
        {
            for(int j =0;j<m;j++)
            {
                    dict[i-j].Add(mat[i][j]);
            }
        }
        
        foreach(KeyValuePair<int,List<int>> p in dict)
        {
            int k = p.Key;
            p.Value.Sort();
            if(k<0)
            {
                int i,j,z=0;
                for(i=0, j=Math.Abs(k);i<n && j<m;i++,j++)
                {
                    mat[i][j] = p.Value[z++];
                }
            }
            else
            {
                int i,j,z=0;
                for(j=0, i=k;i<n && j<m;i++,j++)
                {
                    mat[i][j] = p.Value[z++];
                }
            } 
        }
        return mat;
        
    }
}