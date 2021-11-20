public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> res = new List<int>();
        int n = nums1.Count();
        int m = nums2.Count();
        Array.Sort(nums2);
        for(int i=0;i<n;i++)
        {
            if(!res.Contains(nums1[i]))
            {
                int low = 0;
                int high = m-1;
                int val = nums1[i];
                while(low<=high)
                {
                    int mid = low+(high-low)/2;
                    if(val==nums2[mid])
                    {
                        res.Add(val);
                        break;
                    }
                    else if(nums2[mid]>val)
                    {
                        high = mid-1;
                    }
                    else
                    {
                        low = mid+1;
                    }
                }
            }
        }
        return res.ToArray();
    }
}