public class Solution {
    public int LongestSubarray(int[] nums) {
        int n = nums.Count();
        int res = 0;
        int j = 0;
        int lastZero = -1;
        for(int i=0;i<n;i++)
        {
            if(nums[i]==1)
            {
                res = Math.Max(i-j+1,res);
            }
            else
            {
                j = lastZero+1;
                lastZero = i;
                res = Math.Max(i-j+1,res);
            }
        }
        return res==0 ? res :res-1;
    }
}