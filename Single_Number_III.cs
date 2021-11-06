public class Solution {
    public int[] SingleNumber(int[] nums) {
        int n = nums.Count();
        int[] ans = new int[2];
        int res = 0;
        for(int j=0;j<n;j++)
        {
            res ^= nums[j];
        }
        int c = 0;
        for(int i=0;i<32;i++)
        { 
            if(((res>>i)&1)==1) 
            {
                c = i;
                break;
            }
        }
        c = 1<<c;
        for(int j=0;j<n;j++)
        {
            if((nums[j]&c)==c)
            {
                ans[0] = ans[0]^nums[j];
            }
        }
        ans[1] = res^ans[0];
        return ans;
    }
}