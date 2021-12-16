public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Count();
        int ans = 0;
        int count = 0;
        for(int i = 0;i < nums.Count(); i++)
        {
            if(nums[i]==0)
            {
                ans=Math.Max(ans,count);
                count=0;
            }
            else
            {
                count++;
            }
        }
        return ans=Math.Max(ans,count);
    }
}