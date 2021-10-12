public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int val = nums[0];
        int n = nums.Count();
        int count =1;
        int maxC = 1;
        int result = nums[0];
        for(int i=1;i<n;i++)
        {
            if(nums[i]!=val)
            {
                if(count>maxC)
                {
                    maxC = count;
                    result = val;
                }
                count =1;
                val = nums[i];
            }
            else
            {
                count++;
            }
        }
        
        if(count>maxC)
        {
                    maxC = count;
                    result = val;
        }
        return result;
    }
}