public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int kv) {
        if(kv<=1) return 0;
        int n = nums.Count();
        int result = 0;
        int j = 0;   
        int i = 0;
        int prod = 1;
        while(j<n)
        {
            prod *= nums[j];
            while(prod>=kv) 
            {
                prod/=nums[i];
                i++;
            }
            result+= j-i+1;
            j++;
        }
        return result;
    }
}