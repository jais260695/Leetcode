public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int n = nums.Count();
        int[] prefixSum = new int[n+1];
        
        for(int i=0;i<n;i++)
        {
            prefixSum[i+1] = prefixSum[i] + nums[i];
        }
        
        int[] result = new int[n];
        
        for(int i=0;i<n;i++)
        {
            result[i] = (prefixSum[n]-prefixSum[i]) - (n-i)*nums[i];
            result[i]+= i*nums[i] - prefixSum[i];
        }
        
        return result;
    }
}