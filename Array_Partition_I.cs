public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Count();
        int sum = 0;
        for(int i=0;i<n;i=i+2)
        {
            sum+=nums[i];
        }
        return sum;
    }
}