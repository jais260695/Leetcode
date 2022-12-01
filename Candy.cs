public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Count();
        int[] prefix = new int[n];
        prefix[0] = 1;
        for(int i=1;i<n;i++)
        {
            if(ratings[i]>ratings[i-1])
            {
                prefix[i]=1+prefix[i-1];
            }
            else
            {
                prefix[i] = 1;
            }
        }

        int right = 1;
        int result = Math.Max(right,prefix[n-1]);
        for(int i=n-2;i>=0;i--)
        {
            if(ratings[i]>ratings[i+1])
            {
                right++;
            }
            else
            {
                right = 1;
            }
            result += Math.Max(right,prefix[i]);
        }

        return result;
    }
}