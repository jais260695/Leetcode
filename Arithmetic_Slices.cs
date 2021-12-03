public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int n = nums.Count();
        int sum = 0;
        int result = 0;
        for(int i = 2;i<n;i++)
        {
            if(nums[i]-nums[i-1]==nums[i-1]-nums[i-2])
            {
                sum+=1;
                result+=sum;
            }
            else
            {
                sum = 0;
            }
        }
        return result;
    }
}