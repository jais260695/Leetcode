public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Count();
        int i = 0;
        int j = 0;
        int result = n+1;
        int sum = 0;
        while(i<=j && j<n)
        {
            while(j<n && sum<target)
            {
                sum+=nums[j];
                j++;
            }
            j--;
            if(sum>=target)
                result = Math.Min(result,j-i+1);
            sum-=nums[i];
            i++;
            j++;
        }
        while(i<n)
        {
            if(sum>=target) result = Math.Min(result,j-i);   
            sum-=nums[i];
            i++;
        }
        return result==n+1 ? 0 : result;;
    }
}