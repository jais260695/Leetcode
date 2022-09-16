public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        
        foreach(int[] mat in matrix)
        {
            int n = mat.Count();
            
            StringBuilder original = new StringBuilder();
            StringBuilder flipped = new StringBuilder();
            
            for(int i=0;i<n;i++)
            {
                original.Append(mat[i]);
                flipped.Append(1-mat[i]);
            }
            
            string orig = original.ToString();
            string flip = flipped.ToString();
            
            if(!dict.ContainsKey(orig))
            {
                dict.Add(orig,0);
            }
            
            if(!dict.ContainsKey(flip))
            {
                dict.Add(flip,0);
            }
            
            dict[orig]++;
            dict[flip]++;
            
        }
        
        int result = 0;
        
        foreach(KeyValuePair<string,int> kvp in dict)
        {
            result = Math.Max(kvp.Value,result);
        }
        
        return result;
    }
}