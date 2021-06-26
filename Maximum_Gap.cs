public class Solution {
    public void CountingSort(int[] nums, int n, int place)
    {
        int[] count = new int[10];
        int[] temp = new int[n];
        for(int i=0;i<n;i++)
        {
            count[(nums[i]/place)%10]++;
        }
        
        for(int i=1;i<10;i++)
        {
            count[i]+=count[i-1];    
        }
        
        for(int i=n-1;i>=0;i--)
        {
            temp[--count[(nums[i]/place)%10]] = nums[i];
        }
        
        for(int i=0;i<n;i++)
        {
            nums[i] = temp[i];
        }
    }
    public void RadixSort(int[] nums, int n)
    {
        int max = nums.Max();
        for(int place = 1; (max/place)>0; place*=10)
        {
            CountingSort(nums, n, place);
        }
    }
        
    public int MaximumGap(int[] nums) {
        int n = nums.Count();
        RadixSort(nums,n);
        int result = 0;
        for(int i=1;i<n;i++)
        {
            if(nums[i]-nums[i-1]>result) 
            {
                result = nums[i]-nums[i-1];
            }
        }
        return result;
    }
}