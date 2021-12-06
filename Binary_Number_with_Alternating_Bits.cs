public class Solution {
    public bool HasAlternatingBits(int n) {
        int i = n&1;
        
        n=n>>1;
        while(n>0)
        {
            if(i==(n&1))
            {
                return false;
            }
            i = n&1;
            n>>=1;
        }
        return true;
    }
}