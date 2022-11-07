public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
        long result = 0;
        int n = nums.Count();
       
        Dictionary<int,int> dict = new Dictionary<int,int>();
        long tempSum = 0;
        
        for(int i=0;i<k-1;i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],0);
            }
            
            dict[nums[i]]++;
            
            tempSum+=nums[i];
        }
        
        for(int i=k-1;i<n;i++)
        {
            tempSum+=nums[i];
            
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],0);
            }
            
            dict[nums[i]]++;
            if(dict.Count()==k)
            {
                result = Math.Max(result,tempSum);
            }
            
            if(dict[nums[i-k+1]]<=1)
            {
                dict.Remove(nums[i-k+1]);
            }
            else
            {
                dict[nums[i-k+1]]-=1;
            }
            
            tempSum-=nums[i-k+1];
        }
        
        return result;
    }
}