public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Count();
        int i = 0;
        while(i<n)
        {
            while(nums[i]>0 && nums[i]<=n && nums[nums[i]-1]!=nums[i])
            {
                int temp = nums[nums[i]-1];
                nums[nums[i]-1] = nums[i]; 
                nums[i] = temp;
            }
            i++; 
        }
        for(i=0;i<n;i++)
        {
            if(nums[i]!=i+1) return i+1;
        }
        return n+1;
    }
}