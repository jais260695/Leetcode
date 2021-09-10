public class Solution {
    public int MaxProfit(int[] prices) {             
        int maxprofit = 0;
        for (int i = 1; i < prices.Count(); i++) {
            if (prices[i] > prices[i - 1])
                maxprofit += prices[i] - prices[i - 1];
        }
        return maxprofit;
    }
}