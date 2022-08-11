public class Solution {
    public int FindMax(int[] nums, int val, int n)
    {
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(nums[mid]<=val)
            {
                l = mid+1;
            }
            else
            {
                h = mid-1;
            }
        }
        return l;   
    }
    public int FindMin(int[] nums, int val, int n)
    {
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(nums[mid]>=val)
            {
                h = mid-1;
            }
            else
            {
                l = mid+1;
            }
        }
        return h;   
    }
    public int[] SearchRange(int[] nums, int target) {
      int n = nums.Count();
        int minIndex = FindMin(nums,target,n);
        int maxIndex = FindMax(nums,target,n);
        int[] ans = new int[2];
        if((minIndex+1)==n || nums[minIndex+1]!=target)
        {
            ans[0] = -1;
        }
        else
        {
            ans[0] = minIndex+1;
        }
        if( (maxIndex-1)==-1 || nums[maxIndex-1]!=target)
        {
            ans[1] = -1;
        }
        else
        {
            ans[1] = maxIndex-1;
        }
        return ans;
    }
}