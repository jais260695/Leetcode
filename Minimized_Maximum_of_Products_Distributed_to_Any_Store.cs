public class Solution {
    public bool IsPossible(int n, int[] quantities, int mid)
    {
        int m = quantities.Count();
        int storesRequired = 0;
        for(int i=0;i<m;i++)
        {
            storesRequired += (int)Math.Ceiling((double)quantities[i]/(double)mid);
        }
        
        return storesRequired<=n;
    }
    public int MinimizedMaximum(int n, int[] quantities) {
        int l = 1;
        int r = 100000;
        
        while(l<=r)
        {
            int mid  = l + (r-l)/2;
            
            if(IsPossible(n,quantities,mid))
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
}