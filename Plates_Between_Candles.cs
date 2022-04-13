public class Solution {
    public int FindRightCandle(List<int> candles,int target,int l,int r)
    {
        while(l<=r)
        {
            int mid = l+(r-l)/2;
            
            if(candles[mid]<=target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return r;
    }
    
    public int FindLeftCandle(List<int> candles,int target,int l,int r)
    {
        while(l<=r)
        {
            int mid = l+(r-l)/2;
            
            if(candles[mid]>=target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return l;
    }
    
    public int[] PlatesBetweenCandles(string s, int[][] queries) {
        int n = s.Length;
        int[] prefixSum = new int[n+1];
        List<int> candles = new List<int>();
        for(int i=0;i<n;i++)
        {
            
            if(s[i]=='*')
            {
                prefixSum[i+1]=prefixSum[i]+1;
            }
            else
            {
                candles.Add(i);
                prefixSum[i+1]=prefixSum[i];
            }
        }
        

        int m = queries.Count();
        
        int[] result = new int[m];
        
        for(int i=0;i<m;i++)
        {
            Console.WriteLine(queries[i][0]+" "+queries[i][1]);
            int l = FindLeftCandle(candles,queries[i][0],0,candles.Count()-1);
            int r = FindRightCandle(candles,queries[i][1],0,candles.Count()-1);
            if(l<=r)
            {
                result[i] = prefixSum[candles[r]]-prefixSum[candles[l]];
            }
                
        }
        
        return result;
    }
}