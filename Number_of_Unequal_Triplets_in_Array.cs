public class Solution {
    public int UnequalTriplets(int[] nums) {
        int n = nums.Count();
        int count = 0;
        for(int i=0;i<n-2;i++)
        {
            for(int j = i+1; j<n-1;j++)
            {
                for(int k=j+1;k<n;k++)
                {
                    if(nums[i]!=nums[j] && nums[j]!=nums[k] && nums[i]!=nums[k])
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
}