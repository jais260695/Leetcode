public class Solution {
    public void Swap(int i, int j, int[] cuts)
    {
        int temp = cuts[i];
        cuts[i] = cuts[j];
        cuts[j] = temp;
    }
    Dictionary<string,int> dp;
    public int Solve(int l, int r, int index, int[] cuts)
    {
        string key = l+"-"+r;
        if(dp.ContainsKey(key)) return dp[key];
        int m = cuts.Count();
        
        int result = int.MaxValue;
        for(int i=index;i<m;i++)
        {
            Swap(index,i,cuts);
            if(cuts[index]>l && cuts[index]<r)
            {
                result = Math.Min(result,Solve(l,cuts[index],index+1,cuts)+Solve(cuts[index],r,index+1,cuts));
            }
            Swap(index,i,cuts);
        }
        
        dp.Add(key,result==int.MaxValue ? 0 : result+r-l);
        return dp[key];
    }
    public int MinCost(int n, int[] cuts) {
        
        dp = new Dictionary<string,int>();
 
        return Solve(0,n,0,cuts);
    }
}