public class Solution {
    public int MaxJump(int[] stones) {
        int n = stones.Count();
        if(n==2) return stones[1]-stones[0];
        int result = int.MinValue;

        for(int i=1;i<n-1;i++)
        {
            result = Math.Max(result, stones[i+1]-stones[i-1]);
        }

        return result;
    }
}