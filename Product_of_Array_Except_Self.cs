public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Count();
        int[] prefix = new int[n];
        prefix[0] = nums[0];
        for(int i = 1;i<n;i++)
        {
            prefix[i]=prefix[i-1]*nums[i];
        }
        int rightProduct=1;
        for(int i = n-1;i>=1;i--)
        {
            prefix[i] = prefix[i-1]*rightProduct;
            rightProduct*=nums[i];
        }
        prefix[0] = rightProduct;
        return prefix;
    }
}