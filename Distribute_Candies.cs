public class Solution {
    public int DistributeCandies(int[] candyType) {
        int n = candyType.Count();
        HashSet<int> hSet = new HashSet<int>();
        for(int i=0;i<n;i++)
        {
            hSet.Add(candyType[i]);
        }
        return Math.Min(hSet.Count(),n/2);
    }
}