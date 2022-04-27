public class Solution {
    
    Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
    Random rnd = new Random();
    public Solution(int[] nums) {
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],new List<int>());
            }
            dict[nums[i]].Add(i);
        }
    }
    
    public int Pick(int target) {
        return dict[target][rnd.Next(0,dict[target].Count())];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */