public class Solution {
    public int MinMoves(int[] nums) {
        int m = nums.Min();
        int res = 0;
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            res += (nums[i] - m);
        }
        return res;
    }
}