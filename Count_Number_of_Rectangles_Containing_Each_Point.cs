public class Solution {
    public int[] CountRectangles(int[][] rectangles, int[][] points) {
        Array.Sort(rectangles,delegate(int[] a, int[] b){
            return a[0] - b[0];
        });              
        
        int n = points.Count();
        int m = rectangles.Count();
        
        List<int>[] dp = new List<int>[101];
        
        for(int i=0;i<=100;i++)
        {
            dp[i] = new List<int>();
        }
        
        for(int i=0;i<m;i++)
        {
            dp[rectangles[i][1]].Add(rectangles[i][0]);
        }
        
        int[] result = new int[n];
        
        for(int i=0;i<n;i++)
        {
            int x = points[i][0];
            int y = points[i][1];
            
            for(int j =  y; j<=100;j++)
            {
                int l = 0;
                int r = dp[j].Count()-1;
                while(l<=r)
                {
                    int mid = l + (r-l)/2;

                    if(dp[j][mid]>=x)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                
                result[i]+=(dp[j].Count()-l);
            }
            
        }
        
        return result;
    }
}