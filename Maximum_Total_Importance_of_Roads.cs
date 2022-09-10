public class Solution {
    public long MaximumImportance(int n, int[][] roads) {
       long[] degree = new long[n];
        
        foreach(int[] road in roads)
        {
            degree[road[0]]++;
            degree[road[1]]++;
        }
        
        Array.Sort(degree);
        
        long result = 0;
        for(long i=1;i<=n;i++)
        {
            result+= (long)(i*degree[i-1]);
        }
        
        return result;
    }
}