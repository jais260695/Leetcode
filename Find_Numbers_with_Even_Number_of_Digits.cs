public class Solution {
    public int FindNumbers(int[] nums) {
        int res = 0;
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            int val = nums[i];
            int t =0;
            while(val!=0)
            {
                val/=10;
                t++;
            }
            if(t%2==0) res++;
        }
        return res;
    }
}