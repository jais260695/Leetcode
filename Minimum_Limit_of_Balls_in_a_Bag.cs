public class Solution {
    
    public bool IsValid(int[] nums,int n,int mid,int maxOperations)
    {
        int operationsNeeded = 0;
        
        for(int i=0;i<n;i++)
        {
            operationsNeeded+= nums[i]/mid;
            if(nums[i]%mid==0)
            {
                operationsNeeded--;
            }
            
        }
        
        return operationsNeeded<=maxOperations;
    }
    
    public int MinimumSize(int[] nums, int maxOperations) {
        int n = nums.Count();
        int low = 1;
        int high = nums.Max();
        
        while(low<=high)
        {
            int mid = low + (high-low)/2;
            
            if(IsValid(nums,n,mid,maxOperations))
            {
                high = mid-1;
            }
            else
            {
                low = mid + 1;
            }
        }
        
        return low;
    }
}