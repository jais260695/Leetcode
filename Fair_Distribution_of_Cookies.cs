public class Solution {
    int k;
    int[] kids;
    int n;
    int[] cookies;
    
    int result = int.MaxValue;
    
    public void Solve(int index)
    {
        if(index==n)
        {
            result = Math.Min(result,kids.Max());
            return;
        }
        for(int i=0;i<k;i++)
        {
            kids[i]+=cookies[index];
            Solve(index+1);
            kids[i]-=cookies[index];
        }
    }
    
    public int DistributeCookies(int[] cookies, int k) {
        this.k=k;
        kids = new int[k];
        n = cookies.Count();
        this.cookies = cookies;
        
        Solve(0);
        
        return result;
    }
}