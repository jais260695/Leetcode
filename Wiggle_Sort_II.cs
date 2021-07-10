public class Solution {
    public void WiggleSort(int[] nums) {
        Array.Sort(nums);
        int n = nums.Count();
        int[] temp = new int[n];
        
        int i = 0;
        for(i=0;i<n;i++)
        {
            temp[i] = nums[i];
        }
        
        int t = n%2!=0?n-1:n-2;
        
        for(i=0;i<n;i++)
        {
            nums[t] = temp[i];
            t=t-2; 
            if(t<0) t = n%2!=0?n-2:n-1;
        }       
    }
}