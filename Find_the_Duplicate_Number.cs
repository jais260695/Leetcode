public class Solution {
    public int FindDuplicate(int[] nums) {
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            int val = Math.Abs(nums[i]);
            if(nums[val-1]<0)
            {
                return val;
            }
            nums[val-1]*=(-1);
        }
        return -1;
    }
}