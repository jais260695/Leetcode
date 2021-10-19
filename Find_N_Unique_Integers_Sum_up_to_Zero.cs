public class Solution {
    public int[] SumZero(int n) {
        int[] result = new int[n];
        for(int i = 1;i<n;i+=2)
        {
            result[i-1] = i;
            result[i] = -i;
        }
        return result;
    }
}