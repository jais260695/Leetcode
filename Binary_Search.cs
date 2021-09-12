public class Solution {
    public int Search(int[] nums, int target) {
        
        int l = 0;
        int h =nums.Count()-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(nums[mid]==target)
                return mid;
            else if(nums[mid]>target)
                h=mid-1;
            else
                l=mid+1;
        }
        return -1;
        
    }
}