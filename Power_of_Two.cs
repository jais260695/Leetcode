public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n==0 || n==int.MinValue) return false;
        
        return (n&(n-1))==0?true:false;
    }
}