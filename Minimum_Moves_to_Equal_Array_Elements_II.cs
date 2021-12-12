public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int n = nums.Count();
        int v = nums[n/2];
        int sum = 0;
        for(int i = 0;i<n;i++)
        {
            sum+=(Math.Abs(nums[i]-v));
        }
        return sum;
    }
}