public class Solution {

    public bool Search(int[] nums, int target) {
        int n =nums.Count(); 
        
       
        int l =0;
        int r = n-1;

        while(l<=r)
        {
            while((l+1) < n && nums[l]==nums[l+1])
            {
                
                l++;
            }
            
            while((r-1) >= 0 && nums[r]==nums[r-1])
            {
                
                r--;
            }
            
            
            if(l>r)
            {
                return target == nums[l];
            }
            
            if(nums[l]==nums[r])
            {
                r--;
            }
            
            int mid = l + (r-l)/2;
            
            if(target == nums[mid])
            {
                return true;
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
        return false;
    }
}