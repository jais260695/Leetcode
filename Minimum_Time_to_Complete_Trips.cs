public class Solution {
    long Count(int[] time,int n, long mid)
    {
        long count = 0;
        for(int i=0;i<n;i++)
        {
            count+=(mid/time[i]);
        }
        return count;
    }
    public long MinimumTime(int[] time, int totalTrips) {
        int n = time.Count();
        long l = 1;
        long r = (long)Math.Pow(10,14);

        while(l<=r)
        {
            long mid = l + (r-l)/2;
            if(Count(time, n, mid) < totalTrips)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }

        }

        return l;
    }
}