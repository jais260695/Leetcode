public class Solution {
    public int NumOfPairs(string[] nums, string target) {
        int n = nums.Count();
        int count = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(j==i) continue;
                if(nums[i]+nums[j]==target)
                {
                    count++;
                }
            }
        }
        return count;
    }
}