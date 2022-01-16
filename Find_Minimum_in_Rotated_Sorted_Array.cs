public class Solution {
    public int FindMin(int[] nums) {
        int val = nums[0];
        int n =nums.Count();
        int l =0;
        int h = n-1;
        
        while(l<=h)
        {
            int mid = l + (h-l)/2;
            
            if((mid+1>=n || nums[mid]<nums[mid+1]) && (mid-1<0 || nums[mid]<nums[mid-1]))
            {
                return nums[mid];
            }
            else if(nums[mid]>=val)
            {
                l =mid+1;
            }
            else if(nums[mid]<=val)
            {
                h = mid-1;
            }            
        }
        return nums[0];
    }
}