public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int h = nums.Count()-1;
        int l = 0;
        
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(nums[mid] == target) return mid;
            else if(nums[mid]<target) l = mid+1;
            else h = mid -1;
        }
        return l;
    }
}