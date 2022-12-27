public class Solution {
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks) {
        int n = capacity.Count();
        int[] remaining = new int[n];

        for(int i=0;i<n;i++)
        {
            remaining[i] = capacity[i] - rocks[i];
        }

        Array.Sort(remaining);

        int currCount = 0;
        int sum = 0;
        while(currCount<n && sum+remaining[currCount]<=additionalRocks)
        {
            sum+=remaining[currCount];
            currCount++;
        }

        return currCount;
    }
}