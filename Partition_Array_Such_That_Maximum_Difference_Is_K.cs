public class Solution {
    public int PartitionArray(int[] nums, int k) {
        int n = nums.Count();
        Array.Sort(nums);
        
        int result = 0;
        
        int start = 0;
        
        while(start<n)
        {
            int key = nums[start] + k;
            
            int index = start;
            
            int l = start;
            int r = n-1;
            
            while(l<=r)
            {
                int mid = l + (r-l)/2;
                
                if(nums[mid]>key)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            
            result++;
            
            start = l;
        }
        
        return result;
    }
}