public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int n = mat.Count();
        int m = mat[0].Count(); 
        int total = n*m;
        int totalNew = r*c;
        if(total==totalNew)
        {
            int[][] matNew = new int[r][];
            for(int i=0;i<r;i++)
            {
                matNew[i] = new int[c];
            }
            for(int i=0;i<n*m;i++)
            {
                    matNew[i/c][i%c] = mat[i/m][i%m];
            }
            return matNew;
        }
        else
        {
            return mat;
        }
    }
}