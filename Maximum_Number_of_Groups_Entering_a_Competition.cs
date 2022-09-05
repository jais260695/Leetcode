public class Solution {
    public int MaximumGroups(int[] grades) {
        return (int)(Math.Sqrt(1 + 8*grades.Count()) - 1)/2;
    }
}