public class Solution {
    public int FindShortestSubArray(int[] nums) {
        Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
       
        for(int i=0;i<nums.Count();i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],new List<int>());
            }
            dict[nums[i]].Add(i);
        }
        int maxCount = 0;
        int ans = int.MaxValue;
        foreach(KeyValuePair<int,List<int>> kvp in dict)
        {
            if(kvp.Value.Count()>maxCount)
            {
                maxCount = kvp.Value.Count();
                ans = kvp.Value[kvp.Value.Count()-1]-kvp.Value[0]+1;
            }
            else if(kvp.Value.Count()==maxCount)
            {
                ans = Math.Min(ans,kvp.Value[kvp.Value.Count()-1]-kvp.Value[0]+1);
            }
        }
        return ans;
    }
}