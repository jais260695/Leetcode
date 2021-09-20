public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        int n = nums.Count();
        List<int> result = new List<int>();
        for(int i=0;i<n;i++)
        {
            int val = Math.Abs(nums[i]);
            if(nums[val-1]<0)
            {
                result.Add(val);
            }
            else
            {
                nums[val-1] = (-1)*nums[val-1];
            }
        }
        
        return result.ToList<int>();
    }
}