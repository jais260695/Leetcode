public class Solution {
    public void Solve(int curr, int n, List<int> grayCode)
    {
        if(n==curr) return;
        
        int mask = 1<<curr;
        int m = grayCode.Count();
        for(int i=grayCode.Count()-1;i>=0;i--)
        {
             grayCode.Add(grayCode[i]|mask);
        }
        
        Solve(curr+1,n,grayCode);
    }
    public List<int> GrayCode(int n) {
        List<int> grayCode = new List<int>();
        grayCode.Add(0);
        grayCode.Add(1);
        Solve(1,n,grayCode);
        
        return grayCode;
    }
    public IList<int> CircularPermutation(int n, int start) {
        List<int> grayCode = GrayCode(n);        
        List<int> result = new List<int>();
        
        int i = 0;       
        while(grayCode[i]!=start)
        {
            i++;
        }
        
        int j = i;        
        while(j<grayCode.Count())
        {
            result.Add(grayCode[j]);
            j++;
        }
        
        j = 0;
        while(j<i)
        {
            result.Add(grayCode[j]);
            j++;
        }
        
        return result.ToList<int>();
    }
}