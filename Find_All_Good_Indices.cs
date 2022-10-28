public class Solution {
    public IList<int> GoodIndices(int[] nums, int k) {
        int n = nums.Count();
        int[] prefixCount = new int[n];
        int[] suffixCount = new int[n];
        prefixCount[0] = 1;
        suffixCount[n-1] = 1;
        for(int i=1;i<n;i++)
        {
            prefixCount[i] = 1;
            if(nums[i]<=nums[i-1])
            {
                prefixCount[i] += prefixCount[i-1];
            }
            
            
            suffixCount[n-i-1] = 1;
            if(nums[n-i-1]<=nums[n-i])
            {
                suffixCount[n-i-1] += suffixCount[n-i];
            }
        }
        
        List<int> result = new List<int>();
        
        for(int i=k;i<(n-k);i++)
        {
            if(prefixCount[i-1]>=k && suffixCount[i+1]>=k)
            {
                result.Add(i);
            }
        }
        
        return result.ToList<int>();
    }
}