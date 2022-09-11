public class Solution {
    public int MostFrequentEven(int[] nums) {
        int n = nums.Count();
        
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i=0;i<n;i++)
        {
            if(nums[i]%2==0)
            {
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i],0);
                }
                
                dict[nums[i]]++;
            }
        }
        
        int result = -1;
        
        int max = 0;
        
        foreach(KeyValuePair<int,int> kvp in dict)
        {
            if(kvp.Value>=max)
            {
                if(kvp.Value==max)
                {
                    result = Math.Min(result,kvp.Key);
                }
                else
                {
                    result = kvp.Key;
                }
                max = kvp.Value;
            }
            
        }
        
        return result;
    }
}