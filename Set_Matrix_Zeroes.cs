public class Solution {
    public void SetZeroes(int[][] matrix) {
        
        int m = matrix.Count();
        int n = matrix[0].Count();
        int row = -1,col = -1;
        if(matrix[0][0]==0)
        {
            row = 0;
            col = 0;
        }
        else
        {
            for(int i=1;i<m;i++)
            {
                if(matrix[i][0] == 0)
                {
                    col = 0;
                    break;
                }
            }
            for(int j=1;j<n;j++)
            {
                if(matrix[0][j] == 0)
                {
                    row = 0;
                    break;
                }
            }
        }
        
        
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(matrix[i][j]==0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for(int i=1;i<m;i++)
        {
            if(matrix[i][0]==0)
            {
                for(int j=1;j<n;j++)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        
        for(int j=1;j<n;j++)
        {
            if(matrix[0][j]==0)
            {
                for(int i=1;i<m;i++)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        
        if(col==0)
            for(int i=0;i<m;i++)
            {
                matrix[i][0] = 0;
            }
        
        if(row==0)
            for(int j=0;j<n;j++)
            {
                matrix[0][j] = 0;
            }
    }
}