public class Solution {
    public bool BinarySearch(int[]arr, int val, int n, int diff)
    {
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l + (h-l)/2;
            if(Math.Abs(arr[mid] - val) <= diff)
            {
                return false;
            }
            if(arr[mid]<val)
            {
                l = mid+1;
            }
            else
            {
                h = mid-1;
            }
        }
        return true;
        
    }
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int n1 = arr1.Count();
        int n2 = arr2.Count();
        Array.Sort(arr2);
        int res = 0;
        for(int i=0;i<n1;i++)
        {
            int val = arr1[i];
            if(BinarySearch(arr2,val,n2,d))
            {
                res++;
            }
        }
        return res;
    }
}   