public class Solution {
    Dictionary<IList<int>,int> dp = new Dictionary<IList<int>,int>();
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs) {
        if(dp.ContainsKey(needs)) return dp[needs];
        int sum = 0;
        int n = price.Count();
        int m = special.Count();
        for(int i=0;i<n;i++)
        {
            sum+=(needs[i]*price[i]);
        }        
        for(int i = 0;i < m; i++)
        {
            IList<int> temp = new List<int>();
            for(int j=0;j<n;j++)
            {
                if(needs[j]<special[i][j])
                {
                    break;
                }  
                temp.Add(needs[j]-special[i][j]);
            }
            if(temp.Count()==n)
            {
                sum = Math.Min(sum,special[i][n] + ShoppingOffers(price,special,temp));
            }
        }
        dp.Add(needs,sum);
        return sum;
    }
}