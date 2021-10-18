public class Solution {
    public int OddCells(int n, int m, int[][] indices) {
        int[,] mat = new int[n,m];
        
        int len = indices.Count();
        for(int ind = 0;ind<len;ind++)
        {
            int r = indices[ind][0];
            int c = indices[ind][1];
            
            for(int i = 0;i<m;i++)
            {
                mat[r,i]+=1;
            }
            
            for(int i = 0;i<n;i++)
            {
                mat[i,c]+=1;
            }
        }
        int count = 0;
        for(int i = 0;i<n;i++)
        {
            for(int j = 0;j<m;j++)
            {
                if(mat[i,j]%2!=0)
                    count++;
            }
        }
        return count;
    }
}