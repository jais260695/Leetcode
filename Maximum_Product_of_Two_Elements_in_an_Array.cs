public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums);
        int n = nums.Count();
        return (nums[n-1]-1)*(nums[n-2]-1);
    }
}