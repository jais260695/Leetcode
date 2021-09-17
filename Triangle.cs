public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n = triangle.Count();
        for(int i=1;i<n;i++)
        {
            triangle[i][0] = triangle[i][0]+triangle[i-1][0];
            for(int j=1;j<i;j++)
            {
                triangle[i][j] = triangle[i][j]+Math.Min(triangle[i-1][j],triangle[i-1][j-1]);
            }
            triangle[i][i] = triangle[i][i]+triangle[i-1][i-1];    
        }
        int result = int .MaxValue;
        foreach(int val in triangle[n-1])
        {
            result = Math.Min(result,val);
        }
        return result;
    }
}