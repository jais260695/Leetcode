public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dict = new HashSet<int>();
        int n = nums.Count();
        for(int i =0;i<n;i++)
        {
            if(!dict.Contains(nums[i]))
            {
                dict.Add(nums[i]);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}