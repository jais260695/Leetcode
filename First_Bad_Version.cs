/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(IsBadVersion(mid))
            {
                h = mid-1;
            }
            else
            {
                l = mid+1;
            }
        }
        return h+1; 
    }
}