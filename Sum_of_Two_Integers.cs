public class Solution {
    public int GetSum(int a, int b) {
        int sum = (a^b);
        int carry = ((a&b)<<1);
        if(carry==0) return sum;
        return GetSum(sum,carry);
    }
}