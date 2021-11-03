public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int low=0,high=A.Count()-1;
        while(low<=high)
        {
            int mid=low+(high-low)/2;
            if(mid-1<0 || A[mid]>A[mid-1])
            {
                low=mid+1;
            }
            else
            {
                high=mid-1;
            }
        }
        return high;
    }
}