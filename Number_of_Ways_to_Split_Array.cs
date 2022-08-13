public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int n = nums.Count();        
        int result = 0;
        long totalSum = 0;
        for(int i=0;i<n;i++)
        {
           totalSum += (long)nums[i];
        }
        
        long targetSum = totalSum%2==0 ? totalSum/2 : (totalSum+1)/2;

        long currSum = 0;
        for(int i=0;i<n-1;i++)
        {
           currSum+= (long)nums[i];
           
           if(currSum >= targetSum)
           {
               result++;
           }
        }
        
        return result;
    }
}