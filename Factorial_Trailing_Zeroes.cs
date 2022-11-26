public class Solution {
    public int TrailingZeroes(int n) {
        if(n==0) return 0;
        int countZeroes = 0;
        int countFives = 0;
        int countTwos = 0;
        
        for(int i=n;i>0;i--)
        {
            int t = i;
            while((t%10)==0)
            {
                countZeroes++;
                t/=10;
            }

            while((t%5)==0)
            {
                countFives++;
                t/=5;
            }

            while((t%2)==0)
            {
                countTwos++;
                t/=2;
            }
        }

        return countZeroes + Math.Min(countFives,countTwos);
    }
}