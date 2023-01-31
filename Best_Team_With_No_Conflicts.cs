public class Solution {
    int n;
    int[][] ageAndScore;
    int[,] dp;
    int Solve(int current, int prev)
    {
        if(current == n) return 0;
        if(dp[current,prev+1]!=0) return dp[current,prev+1];
        int result = Solve(current+1,prev);
        if(prev==-1 ||  ageAndScore[current][1]>=ageAndScore[prev][1])
        {
            result = Math.Max(result ,ageAndScore[current][1] + Solve(current+1,current));          
        }      
        return dp[current,prev+1] = result;
    }
    public int BestTeamScore(int[] scores, int[] ages) {
        n = scores.Count();
        ageAndScore = new int[n][];
        dp = new int[n,n];
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            sum+=scores[i];
            ageAndScore[i] = new int[]{ages[i], scores[i]};
        }

        Array.Sort(ageAndScore, delegate(int[] a, int[] b)
            { 
                return a[0]!=b[0] ? a[0]-b[0] : a[1] - b[1] ;
            } 
        );

        return Solve(0,-1);
    }
}