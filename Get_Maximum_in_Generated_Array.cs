public class Solution {
    public int GetMaximumGenerated(int n) {
        if(n<=1) return n;
        int[] nums = new int[n+1];
        nums[0] = 0;
        nums[1] =1;
        int res = 0;
        int c = 1;
        for(int i=2;i<n;i+=2)
        {
            nums[i] = nums[c];
            res = Math.Max(res,nums[i]);
            
            nums[i+1] = nums[c] + nums[c+1];
            res = Math.Max(res,nums[i+1]);
            
            c++;
        }
        
        if(n%2==0)
        {
            nums[n] = nums[c];
            res = Math.Max(res,nums[n]);
        }
        return res;
    }
}