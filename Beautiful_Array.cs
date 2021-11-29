public class Solution {
    Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
    public int[] BeautifulArray(int N) {
        int[] res = new int[N];
        if(dict.ContainsKey(N)) return dict[N];
        if(N==1)
        {
            res[0] = 1;
            dict[N] = res;
            return res;
        }
        
        if(N==2)
        {
            res[0] = 1;
            res[1] = 2;
            dict[N] = res;
            return res;
        }
        
        int[] left = BeautifulArray(N/2);
        int[] right = BeautifulArray((N+1)/2);
        
        int j = 0;
        for(int i=0;i<N/2;i++)
        {
            res[j++] = left[i]*2;
        }
        
        for(int i=0;i<(N+1)/2;i++)
        {
            res[j++] = right[i]*2-1;
        }
        dict[N] = res;
        return res;
    }
}