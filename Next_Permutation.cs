public class Solution {    
    public int JustGreater(int l, int r, int key, int[] nums)
    {
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(nums[mid]<=key)
            {
                r = mid-1;
            }
            else
            {
                l = mid + 1;
            }
        }  
        return r;
    }
    
    public void Swap(int i, int j, int[] nums)
    {
        int temp = nums[i];
        nums[i]= nums[j];
        nums[j] = temp;
        return;
    }
    
    public void QuickSort(int l, int r, int[] nums)
    {
        if(l<r)
        {
            int pivot = FindPivot(l, r, nums);
            QuickSort(l,pivot-1,nums);
            QuickSort(pivot+1,r,nums);
        }
        return;
    }
    
    public int FindPivot(int l, int r, int[] nums)
    {
        int j = l-1;
        for(int i = l;i<r;i++)
        {
            if(nums[i]<=nums[r])
            {
                j++;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
        int t = nums[r];
        nums[r] = nums[j+1];
        nums[j+1] = t;
        return j+1;    
    }
    
    public void NextPermutation(int[] nums) {
        int n = nums.Count();
        int i = n-1;        
        while(i-1>=0 && nums[i]<=nums[i-1])
        {
            i--;
        }        
        if(i==0)
        {
            QuickSort(0,n-1,nums);
            return;
        }       
        int justGreater = JustGreater(i,n-1,nums[i-1],nums);
        Swap(i-1,justGreater,nums);
        QuickSort(i,n-1,nums);
    }
}