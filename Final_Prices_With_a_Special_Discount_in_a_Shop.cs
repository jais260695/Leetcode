public class Solution {
    public int[] FinalPrices(int[] prices) {
        int n = prices.Count();
        for(int i=0;i<n-1;i++)
        {
            int disc = 0;
            for(int j=i+1;j<n;j++)
            {
                if(prices[j]<=prices[i])
                {
                    disc = prices[j];
                    break;
                }
            }
            prices[i] -=disc;
        }
        return prices;
    }
}