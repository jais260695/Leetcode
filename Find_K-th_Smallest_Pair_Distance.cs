public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int n = nums.Count();
        int l = int.MaxValue;
        for(int i=0;i<n-1;i++)
        {
            int diff = nums[i+1]-nums[i];
            l = Math.Min(l,diff);
        }        
        int h = nums[n-1]-nums[0];   
        while(l<=h)
        {
            int mid = l + (h-l)/2;
            int count = BinarySearch(nums, mid, n);
            if(count>=k) h = mid-1;
            else l = mid+1;
        }
        return l;
    }
    
    public int BinarySearch(int[] nums,int val,int n)
    {
       int count = 0;
        for(int i=0;i<n-1;i++)
        {
            int l = i;
            int h = n-1;
            int v = nums[i] + val;
            while(l<=h)
            {
                int mid = l + (h-l)/2;
                if(nums[mid]<=v) l=mid+1;
                else h = mid-1;
            }
            count += (l-1-i);
        }       
        return count;
    }
}