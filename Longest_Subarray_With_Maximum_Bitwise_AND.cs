public class Solution {
    public int LongestSubarray(int[] nums) {
        int n = nums.Count();
        
        
        int max = 0;
       int result = 0;
        
        int i =0;
        while(i<n)
        {
            int j = i;
            while(j<n && nums[j]==nums[i])
            {
                j++;
            }
            
            if(max<=nums[i])
            {
                if(max==nums[i])
                {
                    result = Math.Max(result,j-i);
                }
                else
                {
                    result = j-i;
                }
                
                max = nums[i];
            }
            
            i = j;
        }
        
        return result;
    }
}