public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        List<int> result = new List<int>();
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            result.Insert(index[i],nums[i]);
        }
        return result.ToArray();
    }
}