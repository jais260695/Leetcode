 public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i],new List<int>());
            dict[nums[i]].Add(i);
        }
        int[] res = new int[2];
        for(int i=0;i<n;i++)
        {
            res[0]=i;
            dict[nums[i]].Remove(i);
            if(dict.ContainsKey(target-nums[i]) && dict[target-nums[i]].Count()>0)
            {
                res[1]=dict[target-nums[i]][0];
                return res;
            }
            
        }
        return res;
        
    }
}