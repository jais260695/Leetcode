public class Solution {
    public int TriangularSum(int[] nums) {
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            for(int j=n-1;j>i;j--)
                nums[j] = (nums[j]+nums[j-1])%10;
        }
        return nums[n-1];
    }
}