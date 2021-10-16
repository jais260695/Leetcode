public class Solution {
    public int NumberOfMatches(int n) {
        int sum = 0;
        while(n>1)
        {
            sum+=(n/2);
            n = (n+1)/2;           
        }
        return sum;
    }
}