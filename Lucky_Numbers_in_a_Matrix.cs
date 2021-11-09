public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int n = matrix.Count();
        int m = matrix[0].Count();
        int[] min = new int[n];
        int[] max = new int[m];
        for(int i=0;i<n;i++)
        {
            int last = int.MaxValue;
            for(int j=0;j<m;j++)
            {
                if(last>matrix[i][j])
                {
                    last = matrix[i][j];
                }
                
            }
            min[i] = last;
        }
        for(int i=0;i<m;i++)
        {
            int last = int.MinValue;
            for(int j=0;j<n;j++)
            {
                if(last<matrix[j][i])
                {
                    last = matrix[j][i];
                }
                
            }
            max[i] = last;
        }
        List<int> result = new List<int>();
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(min[i]==max[j] && min[i] == matrix[i][j])
                {
                    result.Add(matrix[i][j]);
                }
            }
        }
        return result.ToList<int>();
    }
}