public class Solution {
    public bool Search(int[] arr, int key, int m)
    {
        int l = 0;
        int r = m-1;
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(arr[mid]==key)
            {
                return true;
            }
            else if(arr[mid]>key)
            {
                r = mid - 1;
            }
            else
            {
                l = mid+1;
            }
        }
        return false;
    }
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Count();
        int m = matrix[0].Count();
        for(int i=0;i<n;i++)
        {
            if(target>=matrix[i][0] && target<=matrix[i][m-1])
            {
                 if(Search(matrix[i],target,m)) return true;
            }
        }
        return false;
        
    }
}