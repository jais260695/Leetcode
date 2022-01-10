public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Count();
        int i=-1;
        int j=0;
        while(j<n)
        {
            while(j<n-1 && nums[j]==nums[j+1])
            {
                j++;
            }
            i++;
            nums[i] = nums[j];
            j++;
        }
        return i+1;
    }
}