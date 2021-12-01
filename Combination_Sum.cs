public class Solution {
    List<List<int>> result = new List<List<int>>();
    List<int> res = new List<int>();
    public void Solve(int[] candidates, int target, int n, int curr)
    {
        if(target<0) return;
        
        if(target==0)
        {
            result.Add(new List<int>(res));
            return;
        }
        
        for(int i = curr ;i< n;i++)
        {
            res.Add(candidates[i]);
            Solve(candidates,target-candidates[i],n,i);
            res.RemoveAt(res.Count()-1);
        }
    }
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Solve(candidates,target,candidates.Count(),0);
        return result.ToList<IList<int>>();
    }
}