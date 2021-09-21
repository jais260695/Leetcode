public class Solution {
    public int IntegerBreak(int n) {
        if(n==2) return 1;
        if(n==3) return 2;
        if(n==4) return 4;
        int mid = 3;
        int i = 5;
        int result = 0;
        while(i<=n)
        {
            result = 2*mid;
            if(i==n) break;;
            i++;
            result = 3*mid;
            if(i==n) break;;
            i++;
            result = 4*mid;
            if(i==n) break;
            i++;
            mid=mid*3;
        }
        return result;
    }
    
}