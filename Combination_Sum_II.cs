public class Solution {
    List<List<int>> res = new List<List<int>>();
    List<int> temp = new List<int>();
    public void Combination(int[] candidates, int l, int h,int sum)
    {
        if(sum==0)
        {
            res.Add(new List<int>(temp));    
            return;
        }
            
        for(int i =l;i<=h;i++)
        {
            if(i-1>=l && candidates[i]==candidates[i-1]) continue;
            if(sum-candidates[i]<0) break;
            temp.Add(candidates[i]);
            int j = temp.Count()-1;
            Combination(candidates,i+1,h,sum-candidates[i]);
            temp.RemoveAt(j);
        }
    }
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        int n = candidates.Count();
        Combination(candidates,0,n-1,target);
        return res.ToList<IList<int>>();
    }
}