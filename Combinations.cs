public class Solution {
    List<List<int>> res = new List<List<int>>();
    List<int> temp = new List<int>();
    public void Combination(int l, int h, int k)
    {
        if(k==0)
        {
            res.Add(new List<int>(temp));    
            return;
        }
            
        for(int i =l;i<=h;i++)
        {
            temp.Add(i);
            Combination(i+1,h,k-1);
            temp.Remove(i);
        }
    }
    public IList<IList<int>> Combine(int n, int k) {
        Combination(1,n,k);
        return res.ToList<IList<int>>();
    }
}