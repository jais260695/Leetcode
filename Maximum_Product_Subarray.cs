public class Solution {
    public int MaxProduct(int[] nums) {
        int n = nums.Count();
        if(nums.Count()==1) return nums[0];
        
        int max_so_far=1;
        int max_result=int.MinValue;
        for(int i=0;i<n;i++)
        { 
            max_so_far*=nums[i];
            if(max_result<max_so_far)
            {
                max_result = max_so_far;
            }
            if(max_so_far==0)
            {
                max_so_far=1;
            }
        }
        max_so_far = 1;
        for(int i=n-1;i>=0;i--)
        { 
            max_so_far*=nums[i];
            if(max_result<max_so_far)
            {
                max_result = max_so_far;
            }
             if(max_so_far==0)
            {
                max_so_far=1;
            }
        }
        return max_result;
    }
}