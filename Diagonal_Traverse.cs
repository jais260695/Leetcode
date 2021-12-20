public class Solution {
    public int[] FindDiagonalOrder(int[][] matrix) {
        List<int> result = new List<int>();
        int n = matrix.Count();
        if(n==0) return result.ToArray(); 
        int m = matrix[0].Count();

        int c = 0;
        
        for(int i=0;i<m;i++)
        {
            List<int> temp = new List<int>();
            for(int j = i,k=0;j>=0 && k<n;j--,k++)
            {
                temp.Add(matrix[k][j]);
            }
            
            if(c%2==0)
            {    
                temp.Reverse();
                result.AddRange(temp);
            }
            else
            {
                result.AddRange(temp);
            }
            c++;
        }
        
        for(int i=1;i<n;i++)
        {
            List<int> temp = new List<int>();
            for(int k= i,j=m-1;j>=0 && k<n;j--,k++)
            {
                temp.Add(matrix[k][j]);
            }
            
            if(c%2==0)
            {    
                temp.Reverse();
                result.AddRange(temp);
            }
            else
            {
                result.AddRange(temp);
            }
            c++;
        }
        
        return result.ToArray();
    }
}