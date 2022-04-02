public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        int maxPossible = 0;
        int n = nums.Count();
        
        for(int i=0;i<n;i++)
        {
            maxPossible |= nums[i];
        }
        
        int totalSubSets = (int)Math.Pow(2,n);
        
        int result = 0;
        for(int i=1;i<totalSubSets;i++)
        {
            int temp  = i;
            
            int val = 0;
            
            int j = 0;
            while(temp>0)
            {
                if((temp&1)==1)
                {
                    val|=nums[j];
                }
                temp>>=1;
                j++;
            }
            if(val==maxPossible) result++;
        }
        return result;
    }
}