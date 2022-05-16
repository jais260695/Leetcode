public class Solution {
    public int LargestCombination(int[] candidates) {
        int n = candidates.Count();
        int result = 0;
        for(int i=0; i<32;i++)
        {
            int temp = 0;
            for(int j=0;j<n;j++)
            {
                
                if((candidates[j]&1)==1)
                {
                    temp++;
                }
                
                candidates[j]=candidates[j]>>1;
            }
            
            result = Math.Max(result,temp);
        }
        
        return result;
    }
}