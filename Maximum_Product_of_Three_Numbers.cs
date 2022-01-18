public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        int n = nums.Count();
        int multy2 = nums[0]*nums[1]*nums[n-1];
        int multy1 = nums[n-2]*nums[n-3]*nums[n-1];
        return Math.Max(multy2,multy1);
    }
}