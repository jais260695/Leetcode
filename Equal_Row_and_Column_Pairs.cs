public class Solution {
    public int EqualPairs(int[][] grid) {
        Dictionary<string,int> rowDict = new  Dictionary<string,int>();
        Dictionary<string,int> colDict = new  Dictionary<string,int>();
        int n = grid.Count();
        
        for(int i=0;i<n;i++)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            
            for(int j=0;j<n;j++)
            {
                sb1.Append(grid[i][j]);
                sb1.Append("|");
                
                sb2.Append(grid[j][i]);
                sb2.Append("|");
            }
            
            string row = sb1.ToString();
            if(!rowDict.ContainsKey(row))
            {
                rowDict.Add(row,0);
            }
            rowDict[row]++;
            
            string col = sb2.ToString();
            if(!colDict.ContainsKey(col))
            {
                colDict.Add(col,0);
            }
            colDict[col]++;
            
        }
        
        int result = 0;
        
        foreach(KeyValuePair<string,int> kvp in rowDict)
        {
            if(colDict.ContainsKey(kvp.Key))
            {
                result+=(kvp.Value*colDict[kvp.Key]);
            }
        }
        
        return result;
    }
}