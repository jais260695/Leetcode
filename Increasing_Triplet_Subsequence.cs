public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int n = nums.Count();
        int[] maxRight = new int[n];
        maxRight[n-1] = nums[n-1];
        for(int i=n-2;i>=0;i--)
        {
            maxRight[i] = Math.Max(maxRight[i+1],nums[i]);
        }
        int minLeft = nums[0];
        for(int i=1;i<n;i++)
        {
            if(nums[i]>minLeft && nums[i]<maxRight[i]) return true;
            minLeft = Math.Min(minLeft,nums[i]);
        }       
        return false;
    }
}