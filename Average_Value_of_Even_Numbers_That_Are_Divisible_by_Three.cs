public class Solution {
    public int AverageValue(int[] nums) {
        int n = nums.Count();
        int count = 0;
        int sum = 0;
        
        for(int i=0;i<n;i++)
        {
            if(nums[i]%2==0 && nums[i]%3==0)
            {
                sum+=nums[i];
                count++;
            }
        }
        
        return count==0 ? 0 : sum/count;
    }
}