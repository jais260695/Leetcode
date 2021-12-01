public class Solution {
    List<List<int>> res = new List<List<int>>();
    List<int> temp = new List<int>();
    public void Combination(int l, int h, int k, int sum)
    {
        if(k==0)
        {
            if(sum==0)
                res.Add(new List<int>(temp));    
            return;
        }
            
        for(int i =l;i<=h;i++)
        {
            temp.Add(i);
            Combination(i+1,h,k-1,sum-i);
            temp.Remove(i);
        }
    }
    public IList<IList<int>> CombinationSum3(int k, int n) {
        Combination(1,9,k,n);
        return res.ToList<IList<int>>();
    }
}