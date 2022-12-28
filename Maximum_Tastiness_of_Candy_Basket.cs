public class Solution {

    public int MaximumTastiness(int[] price, int k) {
        int n = price.Count();
        Array.Sort(price);
        
        int l = 0;
        int r = price[n-1] - price[0];
        while(l<=r)
        {
            int mid = l + (r-l)/2;

            int i = 1;
            int prev = price[0];
            int tempK = 1;
            while(i<n)
            {
                
                if(tempK==k) break;
                if(price[i]-prev>=mid)
                {
                    tempK++;
                    prev = price[i];
                }

                i++;
            }
            if(tempK>=k)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        
        
        return l-1;
        
    }
}