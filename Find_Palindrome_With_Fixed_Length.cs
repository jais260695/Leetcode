public class Solution {
    public long[] KthPalindrome(int[] queries, int intLength) {
                    
        int m = queries.Count();
        long[] result = new long[m];

        int totalCount = (intLength+1)/2;

        totalCount = (int)Math.Pow(10,totalCount)  - (int)Math.Pow(10, totalCount-1);

        for(int i=0;i<m;i++)
        {
            if(queries[i]>totalCount)
            {
                result[i] = -1;    
            }
            else
            {
                long temp = (intLength+1)/2;
                temp = (long)Math.Pow(10,temp-1);
                temp = temp + (queries[i]-1);

                result[i] = temp;
                
                if(intLength%2!=0)
                {
                    temp /= 10;
                }

                while(temp>0)
                {
                    result[i] = result[i]*10 + temp%10;

                    temp /= 10;
                }
                
            }
        }

        return result;
    }
}