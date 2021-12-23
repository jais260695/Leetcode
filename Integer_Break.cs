public class Solution {
    public int IntegerBreak(int n) {
        if(n<4) return n-1;
        int x = 0;
        while(true)
        {
            int mid = (int)Math.Pow(3,x);
            if(2+(x*3) == n) return 2*mid;
            if(3+(x*3) == n) return 3*mid;
            if(4+(x*3) == n) return 4*mid;
            x++;
        }
        return -1;
    }
    
}