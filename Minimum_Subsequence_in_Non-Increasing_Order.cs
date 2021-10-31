public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        int n = nums.Count();
        int sum = 0;
        
        for(int i=0;i<n;i++)
        {
            sum+=nums[i];
        }
        
        Array.Sort(nums);
        
        List<int> result = new List<int>();
        int tempSum = 0;
        sum = sum/2;
        for(int i=n-1;i>=0;i--)
        {
            tempSum += nums[i];
            result.Add(nums[i]);
            if(tempSum>sum)
            {
                return result.ToList<int>();
            }
        }
        return null;
    }
}