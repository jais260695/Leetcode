public class Solution {
    List<List<int>> result = new List<List<int>>();
    List<int> res = new List<int>();
    public void Solve(int[] candidates, int target, int n,int sum, int j)
    {
        if(sum==target)
        {
            result.Add(new List<int>(res));
            return;
        }
        
        for(int i =j ;i< n;i++)
        {
            if(sum+candidates[i]<=target)
            {
                sum+=candidates[i];
                res.Add(candidates[i]);
                Solve(candidates,target,n,sum,i);
                res.RemoveAt(res.Count()-1);
                sum-=candidates[i];
            }
        }
    }
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Solve(candidates,target,candidates.Count(), 0,0);
        return result.ToList<IList<int>>();
    }
}