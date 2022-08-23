public class Solution {
    public IList<int> FindLonely(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int n = nums.Count();
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],0);
            }
            dict[nums[i]]++;
        }
        
        List<int> result = new List<int>();
        
        foreach(KeyValuePair<int,int> kvp in dict)
        {
            if(kvp.Value==1 && !dict.ContainsKey(kvp.Key-1) && !dict.ContainsKey(kvp.Key+1))
            {
                 result.Add(kvp.Key);
            }
        }
        
        return result.ToList<int>();
    }
}