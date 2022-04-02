public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int n  = nums.Count();
        int[] left = new int[n/2];
        int[] right = new int[n/2];
        int j = 0;
        int k = 0;
        for(int i=0;i<n;i++)
        {
            if(nums[i]>0)
            {
                left[j++] = nums[i];
            }
            else
            {
                right[k++] = nums[i];
            }
        }
        
        for(int i=0;i<n/2;i++)
        {
            nums[2*i] = left[i];
            nums[2*i+1] = right[i];   
        }
        return nums;
    }
}