public class Solution {

    public int Search(int[] nums, int target) {
        int n =nums.Count(); 
        
       
        int l =0;
        int r = n-1;

        while(l<=r)
        {
            int mid = l + (r-l)/2;
            
            if(target == nums[mid])
            {
                return mid;
            }
            
            if(nums[mid]>=nums[0])
            {
                if(target>=nums[0])
                {
                    if(target>nums[mid])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
                else
                {
                    l = mid + 1;
                }
            }
            else
            {
                if(target>=nums[0])
                {
                    r = mid - 1;
                }
                else
                {
                    if(target>nums[mid])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }               
            }            
        }
        return -1;
    }
}