public class Solution {
    public int FindMaxK(int[] nums) {
        HashSet<int> dict = new HashSet<int>();
        
        int n = nums.Count();
        int result = int.MinValue;
        for(int i=0;i<n;i++)
        {
            if(dict.Contains(nums[i]*(-1)))
            {
                if(result<Math.Abs(nums[i]))
                {
                    result = Math.Abs(nums[i]);
                }
            }
            
            dict.Add(nums[i]);
        }
        
        return result==int.MinValue ? -1 : result;
    }
}