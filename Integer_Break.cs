public class Solution {
    public int IntegerBreak(int n) {
        if(n<4) return n-1;
        if(n==4) return n;
        int x = 3;
        int y = 3;
        while(true)
        {
            if(2+x == n) return 2*y;
            if(3+x == n) return 3*y;
            if(4+x == n) return 4*y;
            x+=3;
            y*=3;
        }
        return -1;
    }
    
}