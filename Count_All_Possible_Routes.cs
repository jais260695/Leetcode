public class Solution {
    int[,] dp;
    int mod = 1000000007;
    public int Solve(int start,int finish,int fuel,int[] locations,int n)
    {
        if(dp[start,fuel]!=-1) return dp[start,fuel];
        
        int result = 0;
        
        if(start==finish)
        {
            result = 1;
        }
        
        
        for(int j=0;j<n;j++)
        {
            
            int requiredFuel = Math.Abs(locations[start] - locations[j]);
            if(j==start || requiredFuel>fuel) continue;            
            result= (result + Solve(j,finish,fuel-requiredFuel,locations,n))%mod;
                
        }
        
        return dp[start,fuel] = result;
    }
    public int CountRoutes(int[] locations, int start, int finish, int fuel) {
        int n = locations.Count();
        dp = new int[n+1,fuel+1];
        
        for(int i=0;i<=n;i++)
        {
            for(int j=0;j<=fuel;j++)
            {
                dp[i,j] = -1;
            }
        }
        
        return Solve(start,finish,fuel,locations,n);
    }
}