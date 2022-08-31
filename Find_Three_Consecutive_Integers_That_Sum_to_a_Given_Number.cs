public class Solution {
    public long[] SumOfThree(long num) {
        long a = num/3;
        if(3*a != num) return new long[0];        
        return new long[3]{a-1,a,a+1};
    }
}