public class Solution {
    public int HeightChecker(int[] heights) {
        int n = heights.Count();
        int[] copy = new int[n];
        for(int i=0;i<n;i++)
        {
            copy[i] = heights[i];
        }
        
        Array.Sort(copy);
        
        int res = 0;
        
        for(int i=0;i<n;i++)
        {
            if(copy[i] != heights[i]) res++;
        }
        return res;
    }
}