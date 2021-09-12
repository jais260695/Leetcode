public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n= nums.Count();
        int[] ans = new int[n];
        int l = 0;
        int r = n-1;
        int i =n-1;
        while(l<r)
        {
            if(Math.Abs(nums[l])>=Math.Abs(nums[r]))
            {
                ans[i] = nums[l]*nums[l];
                l++;
                i--;
            }
            else
            {
                ans[i] = nums[r]*nums[r];
                r--;
                i--;
            }
        }
        ans[i] = nums[r]*nums[r];
        return ans;
    }
}