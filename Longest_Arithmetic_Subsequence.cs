public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        int n = nums.Count();
        Dictionary<int,int>[] dict = new Dictionary<int,int>[n];
        
        for(int i=0;i<n;i++)
        {
            dict[i] = new Dictionary<int,int>();
        }
        
        int result = 0;
        
        for(int i=1;i<n;i++)
        {
            int tempResult = 0;
            for(int j=i-1;j>=0;j--)
            {
                int diff = nums[i] - nums[j];
                
                if(!dict[i].ContainsKey(diff))
                {
                    dict[i].Add(diff,1);
                }
                
                if(dict[j].ContainsKey(diff))
                {
                    dict[i][diff] = Math.Max(dict[i][diff],1 + dict[j][diff]);
                }
                
                
                tempResult = Math.Max(tempResult,dict[i][diff] );
            }
            
            
            result = Math.Max(result,tempResult);
        }
        
        return 1 + result;
    }
}