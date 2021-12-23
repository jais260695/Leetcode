public class NumArray {

    public int[] prefixSum;
    public NumArray(int[] nums) {
        int n = nums.Count();
        prefixSum = new int[n+1];
        prefixSum[0] = 0;
        for(int i=1;i<=n;i++)
        {
            prefixSum[i] = prefixSum[i-1] + nums[i-1];
        }
    }
    
    public int SumRange(int i, int j) {
        return prefixSum[j+1]-prefixSum[i];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */