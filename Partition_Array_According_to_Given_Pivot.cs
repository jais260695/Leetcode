public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int j=-1;
        int n = nums.Count();
        int[] res = new int[n];
        int i=0;
        int k = 0;
        while(i<n)
        {
            if(nums[i]<pivot)
            {
                j++;
                res[j] = nums[i];
            }
            else if(nums[i]==pivot)
            {
                k++;
            }
            
            i++;
        }
        
        while(k>0)
        {
            j++;
            res[j] = pivot;
            k--;
        }
        
        i = 0;
        while(i<n)
        {
            if(nums[i]>pivot)
            {
                j++;
                res[j] = nums[i] ;
            }
            
            i++;
        }
        
        return res;
    }
}