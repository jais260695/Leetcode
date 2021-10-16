public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int n = nums.Count();
        int[] result = new int[n];
        Array.Copy(nums,result,n);
        Array.Sort(result);
        for(int i=0;i<n;i++)
        {
            int j = Array.IndexOf(result,nums[i]);
            nums[i] = j;
        }
        return nums;
    }
}