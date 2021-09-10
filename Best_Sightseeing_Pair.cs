public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int n = values.Count();
        int max  = 0;
        int result = 0;
        for(int i=0;i<n-1;i++)
        {
            max = Math.Max(values[i]+i, max);
            result = Math.Max(result,values[i+1]-i-1 + max);
        }
        return result;
    }
}