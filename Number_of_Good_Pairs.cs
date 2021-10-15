public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int result=0;
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
        foreach(KeyValuePair<int,int> kvp in dict)
        {
            result+=(kvp.Value*(kvp.Value-1)/2);
        }
        return result;
    }
}