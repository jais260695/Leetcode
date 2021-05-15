public class Solution {
    public double BinarySearch(int[] nums1, int[] nums2,int n1, int n2, int n)
    {
        int l = 0;
            int h = n1-1;
            double res = 0;
            while(true)
            {
                int mid1 = l + (h-l)/2;
                if(h==-1) mid1 = -1;
                int mid2 = n - mid1 -2;
                int v1 = mid1>=0?nums1[mid1]:int.MinValue;;
                int u1 = mid1+1<n1?nums1[mid1+1]:int.MaxValue;
                int v2 = mid2>=0?nums2[mid2]:int.MinValue;
                int u2 = mid2+1<n2?nums2[mid2+1]:int.MaxValue;
                if(v1 <= u2 && v2<=u1)
                {
                    res = (double)Math.Max(v1,v2);
                    if((n1+n2)%2==0)
                    {
                        res+= (double)Math.Min(u1,u2);
                        res/=2;
                    }
                    break;
                }
                else if(v1>u2)
                {
                    h = mid1-1;
                }
                else{
                    l = mid1+1;
                }  
            }
        return res;
    }
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Count();
        int n2 = nums2.Count();
        int n = (n1+n2+1)/2; 
        if(n1<=n2)
        {
           return BinarySearch(nums1,nums2,n1,n2,n);
        }        
        return BinarySearch(nums2,nums1,n2,n1,n);
    }
}