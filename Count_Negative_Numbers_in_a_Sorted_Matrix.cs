public class Solution {
    public int CountNegatives(int[][] grid) {
        
        int result = 0;
        int n=grid.Count();
        int m=grid[0].Count();        
        for(int i=0;i<n;i++)
        {
            result+=BinarySearch(grid[i]);
        }
        return result;    
    }
    
    public int BinarySearch(int[] A)
    {
        int low = 0;
        int high = A.Count()-1;
        while(low<=high)
        {
            int mid = low+(high-low)/2;
            if(A[mid]<0)
            {
                high = mid - 1;   
            }
            else
            {
                low = mid + 1;
            }
        }
        return A.Count()-low;
    }
}