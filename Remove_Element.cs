public class Solution {
    public int RemoveElement(int[] nums, int val) {     
        int i = 0;
        int j = nums.Count();
        while(i<j)
        {
            if(nums[i]!=val)
            {
                i++;
            }
            else
            {
                j--;
                nums[i] = nums[j];
            }
        }
        return i;    
    }
}