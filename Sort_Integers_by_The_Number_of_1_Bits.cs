public class Solution {
    
    public int CountSetBits(int val)
    {
        int res = 0;
        while(val>0)
        {
            if((val&1)==1)
            {
                res++;
            }
            val>>=1;
        }
        return res;
    }
    
    public int[] SortByBits(int[] arr) {
        Array.Sort<int>(arr, delegate(int n, int m) 
                        {       
                                int x = CountSetBits(n);
                                int y = CountSetBits(m);
                                if(x == y) return n-m;
                                return x-y;
                        }
                  );
        return arr;
    }
}