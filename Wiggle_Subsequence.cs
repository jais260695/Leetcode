    public class Solution {
    public int WiggleMaxLength(int[] nums) {
        int n = nums.Count();
        int[] dpP = new int[n];
        int[] dpN = new int[n];
        
        dpP[0]=1;
        dpN[0]=1;
        int res = 1;
        for(int i=1;i<n;i++)
        {
            dpP[i] = 1;
            for(int j=0;j<i;j++)
            {
                if(nums[i]>nums[j])
                {
                    dpP[i] = Math.Max(dpP[i],dpN[j]+1);
                }
                if(nums[i]<nums[j])
                {
                    dpN[i] = Math.Max(dpN[i],dpP[j]+1);
                }
                res = Math.Max(res,Math.Max(dpN[i],dpP[i]));
            }
        }
        return res;
    }
}