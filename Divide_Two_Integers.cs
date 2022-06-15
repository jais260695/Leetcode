public class Solution {
    public int Divide(int dividend, int divisor) {
        int isDividendNegative = 0;
        long D = (long)dividend;
        if(dividend<0)
        {
            isDividendNegative = 1;
            D  = Math.Abs(D);
        }
        
        int isDivisorNegative = 0;
        long d = (long)divisor;
        if(divisor<0)
        {
            isDivisorNegative = 1;
            d  = Math.Abs(d);
        }
        
        
        
        int isNegative = isDividendNegative^isDivisorNegative;
        
        if(D<d) return 0 ;
        
        long count = 0;
        
        while(D>=d)
        {
            D-=d;
            count++;
        }
        
        
        long result = count;
        if(isNegative==1)
        {
            result-=count;
            result-=count;
        }
        
        return result>int.MaxValue ? int.MaxValue : (result<int.MinValue ? int.MinValue : (int)result);
        
    }
}