public class Solution {
    public int MissingNumber(int[] nums) {
        int val = 0;
        for(int i=0;i<=nums.Count();i++)
        {
            val^=i;
        }
        
        for(int i = 0;i<nums.Count();i++)
        {
            val^=nums[i];
        }
        return val;
    }
}