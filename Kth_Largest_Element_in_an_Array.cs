public class Solution {
    
    public void Heapify(int[] nums, int i, int n)
    {
        int left = 2*i+1;
        int right = 2*i+2;
        int largest = i;
        if(left<n && nums[left]>nums[largest])
        {
            largest = left;
        }
        if(right<n && nums[right]>nums[largest])
        {
            largest = right;
        }
        if(largest!=i)
        {
            int temp = nums[i];
            nums[i] = nums[largest];
            nums[largest] = temp;
            Heapify(nums,largest,n);
        }
    }
    
    public int FindKthLargest(int[] nums, int k) {
        int n = nums.Count();
        
        for(int i= (n/2)-1;i>=0;i--)
        {
            Heapify(nums,i,n);
        }
        
        int result = 0;
        for(int i=n-1;i>=n-k;i--)
        {
            result = nums[0];
            nums[0] = nums[i];
            Heapify(nums,0,i);
        }
        return result;
        
    }
}