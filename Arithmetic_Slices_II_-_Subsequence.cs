public class Solution {
    
    public int NumberOfArithmeticSlices(int[] nums) {
        int n = nums.Count();
        Dictionary<string,long> dict = new Dictionary<string,long>();
        int result = 0;
        for(int i = 0;i<n;i++)
        {
            for(int j=0;j<i;j++)
            {
                long diff = (long)nums[i] - (long)nums[j];
                string key1 = i+"|"+diff;
                string key2 = j+"|"+diff;
                if(!dict.ContainsKey(key1))
                {
                    dict.Add(key1,1);
                }
                else
                {
                    dict[key1]+=1;
                }
                if(dict.ContainsKey(key2) && dict[key2] >0)
                {
                    dict[key1] +=  dict[key2];
                    
                    result+=(int)dict[key2];
                }
                

            }
        }
        return result;
    }
}