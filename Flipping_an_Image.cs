public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        int n = A.Count();
        int m = A[0].Count();
        for(int i=0;i<n;i++)
        {
            int j = 0;
            while(j<m/2)
            {
                int temp = A[i][j];
                A[i][j] = A[i][m-j-1];
                A[i][m-j-1] = temp;
                
                A[i][j] = 1^A[i][j];
                A[i][m-j-1] = 1^A[i][m-j-1];
                j++;
            }
            if(m%2!=0)
            {
                A[i][j] = 1^A[i][j];
            }
        }
        return A;
    }
}