public class Solution {
    public int NumTimesAllBlue(int[] flips) {
        int result = 0;
        int n = flips.Count();
        int curr = flips[0];
        int count = 1;
        
        if(curr==count) result++;
        
        for(int i=1;i<n;i++)
        {
            
            count++;
            
            curr = Math.Max(curr, flips[i]);
            
            if(curr==count) result++;
            
        }
        
        return result;
    }
}