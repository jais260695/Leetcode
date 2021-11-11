public class Solution {
    public int MinStartValue(int[] nums) {
        int n = nums.Count();
        int[] prefix = new int[n];        
        prefix[0] = nums[0];
        int min = nums[0];
        for(int i=1;i<n;i++)
        {
            prefix[i] = prefix[i-1]+nums[i];
            min=Math.Min(prefix[i],min);
        }
        if(min<1)
        {
            return Math.Abs(min)+1;
        }
        return 1;
    }
}