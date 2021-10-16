public class Solution {
    public int SubarraySum(int[] nums, int kv) {
        int n = nums.Count();
        int[] prefixSum = new int[n];
        prefixSum[0] = nums[0];
        int count = 0;
        if(prefixSum[0]==kv) count++;
        for(int i=1;i<n;i++)
        {
            prefixSum[i]=prefixSum[i-1]+nums[i];
            if(prefixSum[i]==kv) count++;
        }
        for(int i=1;i<n;i++)
        {
            for(int j=i;j<n;j++)
            {
                if(prefixSum[j]-prefixSum[i-1]==kv) count++;
            }
        }
        return count;
    }
}