public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Count();
        List<int> result = new List<int>();
        for(int i=0;i<n;i++)
        {
            int val = Math.Abs(nums[i]);
            if(nums[val-1]>0)
            {
                nums[val-1] = (-1)*nums[val-1];
            }
        }
        for(int i=0;i<n;i++)
        {
            if(nums[i]>0)
            {
                result.Add(i+1);
            }
        }
        
        return result.ToList<int>();
    }
}