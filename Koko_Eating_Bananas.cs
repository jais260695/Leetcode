public class Solution {
    public bool IsValid(int[] piles,int mid, int H)
    {
        int time=0;
        for(int i=0;i<piles.Count();i++)
        {
            time+=(piles[i]/mid);
            if(piles[i]%mid!=0)
            {
                time++;
            }
        }
        return time<=H;
    }
    public int MinEatingSpeed(int[] piles, int H) {
       
        
        int high=int.MinValue;
        int low=1;
        int result=0;
        for(int i=0;i<piles.Count();i++)
        {
            low = Math.Min(piles[i],low);
            high=Math.Max(piles[i],high);
        }
        while(low<=high)
        {
            int mid = low+(high-low)/2;
            if(IsValid(piles,mid,H))
            {
                high=mid-1;
                result = mid;
            }
            else
            {
                low=mid+1;
            }
        }
        
        return result;
        
    }
}