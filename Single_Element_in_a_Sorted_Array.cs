public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int n = nums.Count();
        int l=0,h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if((mid-1<0 || nums[mid-1] != nums[mid]) && 
               (mid+1==n || nums[mid+1] != nums[mid]))
                return nums[mid];
            else if(mid%2==1)
            {
                if(nums[mid-1]==nums[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    h = mid-1;
                }
            }
            else
            {
                if(nums[mid-1]==nums[mid])
                {
                    h = mid - 1;
                }
                else
                {
                    l = mid+1;
                }
            }
        }
        return -1;
    }
}