public class Solution {
    public int SingleNumber(int[] nums) {
        int n = nums.Count();
        int m = 3;
        int res = 0;
        for(int i=0;i<31;i++)
        {
            int count = 0;
            for(int j=0;j<n;j++)
            {
                if(((nums[j]>>i)&1)==1)
                {
                    count++;
                }
            }
            if((count%m)!=0)
            {
                res |= (1<<i);
            }
        }
        return res;
    }
}