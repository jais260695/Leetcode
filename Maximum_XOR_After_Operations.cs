public class Solution {
    public int MaximumXOR(int[] nums) {
        int result = 0;
        
        foreach(int v in nums)
        {
            result |= v;
        }
        
        return result;
    }
}