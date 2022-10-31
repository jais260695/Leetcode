public class Solution {
    public int SumOfDigits(long n)
    {
        int sum = 0;
        while(n>0)
        {
            sum+=(int)(n%10);
            n/=10;
        }
        return sum;
    }
    public long MakeIntegerBeautiful(long n, int target) {
        long prev = n;
        int t = SumOfDigits(n);
        
        if(t<=target) return 0;
        
        int diff = t-target;
        int total = 0;
        long result = 0;
        long tens = 1;
        int temp = 10;
        while(total<=diff)
        {
            total+=(int)(n%10);
            result+= (temp-(n%10))*tens;
            temp = 9;
            tens*=10;
            n/=10;
        }
        
        return result;
    }
}