public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        int result = 1;       
        Array.Sort(nums);
        int n = nums.Count();
        
        int[] prefixSum = new int[n+1];
        prefixSum[0] = 0;
        for(int i=1;i<=n;i++)
        {
            prefixSum[i] = prefixSum[i-1]+nums[i-1];
        }
        for(int i=1;i<n;i++)
        {
            int l = 0;
            int r = i-1;
            while(l<=r)
            {
                int mid = l + (r-l)/2;
                int diff = (i-mid)*nums[i] - (prefixSum[i] - prefixSum[mid]);
                if(diff<=k)
                {
                    result = Math.Max(result,i-mid+1);
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }   
            }            
        }

        return result;
    }
}