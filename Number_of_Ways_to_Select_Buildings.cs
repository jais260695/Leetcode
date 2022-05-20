public class Solution {
    public long NumberOfWays(string s) {
        int n = s.Length;
        long[] prefixOneCount = new long[n+1];
        long[] prefixOneZeroCount = new long[n+1];
        
        long[] prefixZeroCount = new long[n+1];
        long[] prefixZeroOneCount = new long[n+1];
        
        long result = 0;
        
        for(int i=1;i<=n;i++)
        {
            
            if(s[i-1]=='1')
            {
                prefixOneCount[i] = prefixOneCount[i-1] + 1;
                prefixOneZeroCount[i] = prefixOneZeroCount[i-1];
                result+=prefixOneZeroCount[i];
                
                prefixZeroCount[i] = prefixZeroCount[i-1];
                prefixZeroOneCount[i] = prefixZeroCount[i] + prefixZeroOneCount[i-1];
            }
            else
            {
                prefixOneCount[i] = prefixOneCount[i-1];
                prefixOneZeroCount[i] = prefixOneCount[i] + prefixOneZeroCount[i-1];
                
                prefixZeroCount[i] = prefixZeroCount[i-1] + 1;
                prefixZeroOneCount[i] = prefixZeroOneCount[i-1];
                result+=prefixZeroOneCount[i];
            }
            
        }
        
        return result;
    }
}