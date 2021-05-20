public class Solution {
   
   int[] dp;
   int[] prefixSum;
   
   public int util(int[] piles, int index,int n)
   {
       if(index>=n) return 0;
       
       if(dp[index]!=int.MinValue) return dp[index];
       
       int res = int.MinValue;
       for(int x=index; x<n && x<(index+3); x++)
       {
           res = Math.Max(res,(prefixSum[n]-prefixSum[index])-util(piles,x+1,n));
       }
       
       return dp[index] = res;
   }
   
   public string StoneGameIII(int[] piles) {
       int n = piles.Count();

       dp = new int[n];
       prefixSum = new int[n+1];
       prefixSum[0] = 0;
       
       for(int i=0;i<n;i++)
       {
           dp[i] = int.MinValue;
           prefixSum[i+1] = prefixSum[i] + piles[i];
       }
       
       int aliceScore = util(piles,0,n);
       int bobScore = prefixSum[n]-aliceScore;
       
       if(aliceScore>bobScore) return "Alice";
       if(bobScore>aliceScore) return "Bob";
       return "Tie";
   }

}