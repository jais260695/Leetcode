public class Solution {
    
    public void Quicksort(int[] nums, int l, int h)
    {
        if(l<h)
        {
            int mid = FindPivot(nums,l,h);
            Quicksort(nums,l,mid-1);
            Quicksort(nums,mid+1,h);
        }
    }
    
    public int FindPivot(int[] nums, int l, int h)
    {
        int pivot = nums[h];
        int j=l-1;
        for(int i=l;i<h;i++)
        {
            if(nums[i]<=pivot)
            {
                j++;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
        
        j++;
        int temp1 = nums[h];
        nums[h] = nums[j];
        nums[j] = temp1;
        return j;
    }
    
    public int[] SortArray(int[] nums) {
        int l = 0;
        int h = nums.Count()-1;
        Quicksort(nums,l,h);
        return nums;
    }
}