public class Solution {
    public int[] dp ;
    public bool Solve(int maxChoosableInteger, int desiredTotal, int state)
    {
        
        if(dp[state]!=0)
        {
            return dp[state]==1;
        }
        for(int i= 1;i<=maxChoosableInteger;i++)
        {
            int mask = 1<<i;
            if((state & mask)!=mask)
            {
                if(desiredTotal-i<=0 || !Solve(maxChoosableInteger,desiredTotal-i,state|mask))
                {
                    dp[state] = 1;
                    return true;
                }
            }
        }
        dp[state] = -1;
        return false;
    }
    
    public bool CanIWin(int maxChoosableInteger, int desiredTotal) {
            if (maxChoosableInteger*(maxChoosableInteger+1)/2<desiredTotal) return false;
            int total = 1<<21;
        dp = new int[total+1];
          return Solve(maxChoosableInteger,desiredTotal,0);
    }
}