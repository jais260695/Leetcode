public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        int l = 0;
        int h = 1000000000;
        int n = bloomDay.Count();
        int ans = int.MaxValue;
        while(l<=h)
        {
            int mid = l + (h-l)/2;
            int i = 0;
            int c = 0;
            int t =0;
            while(i<n)
            {
                if(bloomDay[i]<=mid)
                {
                    c++;
                }
                else
                {
                    c=0;
                }
                
                if(c==k) 
                {
                    t++;
                    c=0;
                }
                i++;
            }
             
            if(t>=m)
            {
                h = mid-1;
                ans = mid;
            }
            else
            {
                l = mid+1;
            }
            
        }
        
        if(ans == int.MaxValue) return -1;
        return ans;
    }
}