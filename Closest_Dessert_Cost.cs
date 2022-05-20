public class Solution {
    int minimumDifference = int.MaxValue;
    int minimumResult = int.MaxValue;
    
    public void Solve(int[] toppingCosts,int m,  int target,int index, int total)
    {
        if(index==m)
        {
            int diff = Math.Abs(target-total);
            if(diff<minimumDifference)
            {
                minimumDifference = diff;
                minimumResult = total;
            }
            else if(diff==minimumDifference)
            {
                minimumResult = Math.Min(total,minimumResult);
            }
            return;
        }
        
        Solve(toppingCosts,m,target,index+1,total+(0*toppingCosts[index]));
        Solve(toppingCosts,m,target,index+1,total+(1*toppingCosts[index]));
        Solve(toppingCosts,m,target,index+1,total+(2*toppingCosts[index]));
    }
    public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target) {
        int n = baseCosts.Count();
        int m = toppingCosts.Count();

        for(int i=0;i<n;i++)
        {
            Solve(toppingCosts,m,target,0,baseCosts[i]);
        }
        
        return minimumResult;
    }
}