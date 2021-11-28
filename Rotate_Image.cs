public class Solution {
    public void Swap(int[][] matrix,int i,int j,int x,int y)
    {
        int temp = matrix[i][j];
        matrix[i][j] = matrix[x][y];
        matrix[x][y] = temp;
    }
    public void Rotate(int[][] matrix) {
        int n = matrix.Count();
        int m = (n+1)/2;
        for(int i = 0;i<m;i++)
        {
            Swap(matrix,n-1-i,i,n-1-i,n-1-i);
            Swap(matrix,n-1-i,n-1-i,i,n-1-i);
            Swap(matrix,i,n-1-i,i,i);
            for(int j=i+1;j<n-1-i;j++)
            {
                Swap(matrix,n-1-i,j,n-1-j,n-1-i);
            }
            for(int j=i+1;j<n-1-i;j++)
            {
                Swap(matrix,j,n-1-i,i,j);
            }
            for(int j=i+1;j<n-1-i;j++)
            {
                Swap(matrix,i,j,n-1-j,i);
            }
        }
    }
}