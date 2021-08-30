public class Solution {
    public int MinPairSum(int[] nums) {
        int n = nums.Count();
        int res = 0;
        Array.Sort(nums);
        for(int i=0;i<n/2;i++)
        {
            res = Math.Max(nums[i]+nums[n-i-1],res);
        }
        return res;
    }
}