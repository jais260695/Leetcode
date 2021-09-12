public class Solution {
    public void Reverse(int l, int r, int[] nums)
    {
        while(l<r)
        {
            int temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
            l++;
            r--;
        }
    }
    public void Rotate(int[] nums, int k) {
        int n = nums.Count();
        k = k%n;
        Reverse(0,n-1,nums);
        Reverse(0,k-1,nums);
        Reverse(k,n-1,nums);
    }
}