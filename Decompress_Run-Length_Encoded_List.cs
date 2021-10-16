public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        int n = nums.Count();
        List<int> result = new List<int>();
        for(int i=0;i<n;i+=2)
        {
            for(int j=0;j<nums[i];j++)
            {
                result.Add(nums[i+1]);
            }
        }
        return result.ToArray();
    }
}