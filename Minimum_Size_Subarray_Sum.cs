public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Count();
        int i = 0;
        int j = 0;
        int result = n+1;
        int sum = nums[0];
        while(j<=i && i<n)
        {
            if(sum<target)
            {
                i++;
                if(i==n) break;
                sum+=nums[i];
            }
            else
            {
                result = Math.Min(result,i-j+1);
                sum-=nums[j];
                j++;
            }
        }
        return result==n+1 ? 0 : result;
    }
}