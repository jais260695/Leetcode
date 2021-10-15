public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> list = new List<bool>();
        int maxV = candies.Max();
        int n = candies.Count();
        for(int i=0;i<n;i++)
        {
            list.Add(candies[i]+extraCandies>=maxV);
        }
        return list;
    }
}