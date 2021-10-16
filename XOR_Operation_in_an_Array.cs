public class Solution {
    public int XorOperation(int n, int start) {
        
        int result = 0;
        for(int i=0;i<n;i++)
        {
            int val = start+2*i;
            result ^=val;
        }
        return result;
    }
}