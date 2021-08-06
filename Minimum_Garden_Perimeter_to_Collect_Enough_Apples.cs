public class Solution {
    public long MinimumPerimeter(long neededApples) {
        long l = 0;
        long h = 503969;
        while(l<=h)
        {
            long mid = l + (h-l)/2;
            if(2*mid*(mid+1)*(2*mid+1)<neededApples)
            {
                l=mid+1;
            }
            else
            {
                h = mid-1;
            }
        }
        return (2*h+2)*4;
    }
}