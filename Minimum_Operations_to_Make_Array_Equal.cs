public class Solution {
    public int MinOperations(int n) {
        int l = 1;
        int r = 2*(n-1) + 1;
        int result = 0;
        while(l<r)
        {
            result += (r-l)/2;
            l+=2;
            r-=2;
        }
        return result;
    }
}