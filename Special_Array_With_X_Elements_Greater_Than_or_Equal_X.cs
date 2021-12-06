public class Solution {
    public int SpecialArray(int[] arr) {
        int n = arr.Count();
        Array.Sort(arr);
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;            
            if(arr[mid]>=n-mid)
            {
                if(mid-1<0 || arr[mid-1]<n-mid)
                    return n-mid;
                else
                  h = mid-1;  
            }
            else
            {
                l = mid+1;
            }
        }        
        return -1;
    }
}