public class Solution {
    public int ArrangeCoins(int n) {
        return ((int)Math.Sqrt(1+(long)8*n)-1)/2;
    }
}