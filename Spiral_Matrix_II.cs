public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] matrix = new int[n][];
        for(int i=0;i<n;i++)
        {
            matrix[i] = new int[n];
        }
        int m = n;
        int total = 1;
        int i1=0;
        int j1=m-1;
        int i2 = n-1;
        int j2 = 0;
        while(true)
        {
            
            
            for(int i = i1;i<=j1 && i<m;i++)
            {
                matrix[i1][i] = total++;
            }
            if(total>n*n) break;
            for(int i = i1+1;i<=i2 && i<n;i++)
            {
                matrix[i][j1] = total++;
            }
            if(total>n*n) break;
            for(int i = j1-1;i>=j2 && i>=0;i--)
            {
                matrix[i2][i] = total++;
            }
            if(total>n*n) break;
            for(int i = i2-1;i>i1 && i>=0;i--)
            {
                matrix[i][j2] = total++;
            }
            if(total>n*n) break;
            i1++;
            j1--;
            i2--;
            j2++;
        }
        return matrix;
    }
}