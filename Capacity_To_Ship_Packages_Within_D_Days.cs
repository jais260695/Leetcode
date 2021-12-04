public class Solution {
    
    public int Search(int[] weights, int cap)
    {
        int n = weights.Count();
        int res = 0;
        int sum=weights[0];
        for(int i=1;i<n;i++)
        {
            if(sum==cap)
            {
                res++;
                sum = weights[i] ;
            }
            else if(sum<cap)
            {
                if(sum+weights[i]==cap)
                {
                    res++;
                    sum =0 ;
                }
                else if(sum+weights[i]>cap)
                {
                    res++;
                    sum = weights[i];
                }  
                else
                {
                    sum+=weights[i];
                }
            }
            else
            {
                return -1;
            }
        }
        if(sum!=0)
        {
            if(sum<=cap)
                res++;
            else 
                return -1;
        }
        return res;
    }
    public int ShipWithinDays(int[] weights, int D) {
        int low = 0;
        int high = 0;
        int result = int.MaxValue;
        int n = weights.Count();
        int max = weights.Max();
        int maxO = int.MaxValue;
        int sum = 0;
        for(int i =0 ;i<n;i++)
        {
            sum+=weights[i];
        }
        high = sum;
        while(low<=high)
        {
            int mid = low +(high-low)/2;
            int val = Search(weights,mid);
            if(val==-1)
            {
                low=mid+1;
                continue;
            }
            if(val==D)
            {
                if(result>mid)
                   result = mid;
                high--;
            }
            else if(val<D)
            {
                if(maxO>mid)
                   maxO = mid;
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }
        }
        if(result==int.MaxValue && result>maxO)
        {
            result = maxO;
        }
        return result==int.MaxValue?sum:result;
    }
}