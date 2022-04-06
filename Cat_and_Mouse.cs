public class Solution {
    int[,,] dp;
    public int Solve(int[][] graph, int mousePos, int catPos, int turn, int depth)
    {        
        if(mousePos==0) return 1;
        if(mousePos==catPos) return 2;
        if(depth==0) return 0;
        
        if(dp[mousePos,catPos,depth]!=-1)
        {
            return dp[mousePos,catPos,depth];
        }
        
        int result;
        
        if(turn==0)
        {
            result = 2;
            foreach(int v in graph[mousePos])
            {
                int temp = Solve(graph,v,catPos,1,depth-1);

                if(temp==1)
                {
                    result = 1;
                }
                else if(temp==0 && result == 2)
                {
                    result = 0;
                }
            }
        }
        else
        {
            result = 1;
            foreach(int v in graph[catPos])
            {
                if(v==0) continue;
                
                int temp = Solve(graph,mousePos,v,0,depth-1);
                if(temp==2)
                {
                    result = 2;
                }
                else if(temp==0 && result==1)
                {
                    result = 0;
                }
            }
        }
        
        return dp[mousePos,catPos,depth] = result;
    }
    public int CatMouseGame(int[][] graph) {
        int n = graph.Count();
        int depth = 31;
        dp = new int[n,n,depth];      
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                for(int k=0;k<depth;k++)
                {
                    dp[i,j,k] = -1;
                }
            }
        }        
        return Solve(graph,1,2,0,depth-1);
    }
}