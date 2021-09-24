public class Solution {
    public int HammingWeight(uint n) {
        int res = 0;
        while(n>0)
        {
            int v = (int)(n&1);
            res+=v;;
            n>>=1;
        }
        return res;
    }
}