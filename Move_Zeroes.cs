public class Solution {
    public void MoveZeroes(int[] nums) {
        int j = -1;
        for(int i=0;i<nums.Count();i++)
        {
            if(nums[i]!=0)
            {
                j++;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}