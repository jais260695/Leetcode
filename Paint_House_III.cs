public class Solution {
    int[] houses;
    int m;
    int n;
    int[][] cost;
    int[,,] dp;
    int Solve( int index, int prevColor, int target)
    {
        //if desired neighborhood is achived with no remaining houses return 0
        if(target==0 && index==m) return 0;
        // if neighborhood count is more than desired or no remaining houses to complete  neighborhood return int.MaxValue, i.e; not possible
        if(target < 0 || index==m) return int.MaxValue;
        
        //if same scenario already encountered return result
        if(dp[index,prevColor,target]!=-1) return dp[index,prevColor,target];        
        
        int result = int.MaxValue;
        
        //If house is allowed to be painted
        if(houses[index]==0)
        {
            //pick color one by one
            for(int i=1;i<=n;i++)
            {
                //if picked color is same as previous color then neighborhood is same else new neighborhood will start
                int temp = Solve(index+1,i,i==prevColor ? target : target-1);                
                
                //if not possible to create target neighborhoods
                if(temp!=int.MaxValue)
                {
                    result = Math.Min(result,cost[index][i-1] + temp);   
                }             
            }
        }
        else
        {
            //if house was initially painted
            //if painted color is same as previous color then neighborhood is same else new neighborhood will start
            result = Math.Min(result,Solve(index+1,houses[index],houses[index]==prevColor ? target : target-1));
        }
        
        return dp[index,prevColor,target] = result;
    }
    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        this.houses = houses;
        this.m = m;
        this.n = n;
        this.cost = cost;
        
        dp = new int[m,n+1,target+1];
        
        //initialize all states to -1, i.e; assume initially nothing is possible
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<=n;j++)
            {
                for(int k=0;k<=target;k++)
                {
                    dp[i,j,k] = -1;
                }
            }
        }
        
        // solve for index = 0, prevcolor = 0, and target neighborhood
        int result = Solve(0,0,target);
        
        return result==int.MaxValue ? -1 : result;
    }
}