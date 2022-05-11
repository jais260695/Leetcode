public class Solution {
    int[,,] dp ;
    int n;
    public int Solve(int[][] costs, int a, int b, int index)
    {
        if(index==n)
        {
            return 0;
        }
        
        if(dp[a,b,index]!=0) return dp[a,b,index];
        
        int result;
        if(a==0)
        {
            result = costs[index][1] +  Solve(costs,a,b-1,index+1);
        }
        else if(b==0)
        {
            result = costs[index][0] +  Solve(costs,a-1,b,index+1);
        }
        else
        {
            result = Math.Min(costs[index][1] +  Solve(costs,a,b-1,index+1),costs[index][0] +  Solve(costs,a-1,b,index+1));
        }
        
        return dp[a,b,index] = result;
        
    }
    public int TwoCitySchedCost(int[][] costs) {
        n = costs.Count();
        dp = new int[n/2+1,n/2+1,n];
        
        return Solve(costs,n/2,n/2,0);
    }
}