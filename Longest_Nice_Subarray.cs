public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int n = nums.Count();
        int result = 0;
        
        int i = 0;
        int j = 0;
        
        int sum = 0;
        
        while(i<=j && j<n)
        {
           if((sum^nums[j])==(sum+nums[j])) 
           {
               sum += nums[j];
               result = Math.Max(result,j-i+1);
               j++;
           }
           else
           {
               sum -= nums[i];
               i++;
           }
                
        }
        
        return result;
    }
    
}