public class Solution {
    public int TotalHammingDistance(int[] nums) {
        int n = nums.Count();
        int ans = 0;
        for(int b=0;b<32;b++)
        {
            int ones = 0;
            int zeroes = 0;
            int flag = 1;
            for(int i=0;i<n;i++)
            {
                if(nums[i]!=0) flag = 0;
                if((nums[i]&1)==1)
                {
                    ones++;
                }
                else
                {
                    zeroes++;
                }
                nums[i]>>=1;
            }
            if(flag==1) break;
            ans+=(ones*zeroes);
        }
        return ans;
    }
}