public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        int n = nums.Count();
        int[] prefixXOR = new int[n];
        prefixXOR[0] = nums[0];
        for(int i=1;i<n;i++)
        {
            prefixXOR[i] = nums[i]^prefixXOR[i-1];
        }
        int[] ans = new int[n];        
        int K = (1<<maximumBit) - 1;
        for(int i = n-1;i>=0;i--)
        {
            ans[n-i-1] = K^prefixXOR[i];
        }
        return ans;
    }
}