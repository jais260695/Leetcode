public class Solution {
    IList<string>[] dp;
    public IList<string> GenerateParenthesisUtil(int n) {
        if(n==0) return new List<string>();
        if(n==1) return new List<string>(){"()"};
        
        if(dp[n]!=null)
        {
            return dp[n].ToList<string>();
        }
        
        IList<string> ans = new List<string>();
        IList<string> temp1 = new List<string>();
        IList<string> temp2 = new List<string>();
        
        for(int i=0;i<=(n-1)/2;i++)
        {
            temp1.Clear();
            temp1 = GenerateParenthesisUtil(i);
            temp2.Clear();
            temp2 = GenerateParenthesisUtil(n-1-i);
            if(temp1.Count()!=0 && temp2.Count()!=0)
            {
                foreach(string s1 in temp1)
                { 
                    foreach(string s2 in temp2)
                    {
                        if(!ans.Contains("("+s1+s2+")")) ans.Add("("+s1+s2+")");
                        if(!ans.Contains("("+s1+")"+s2)) ans.Add("("+s1+")"+s2);
                        if(!ans.Contains("("+s2+")"+s1)) ans.Add("("+s2+")"+s1);
                    }
                }
            }
            else if(temp1.Count()!=0)
            {
                foreach(string s1 in temp1)
                { 
                        if(!ans.Contains("("+s1+")")) ans.Add("("+s1+")");
                        if(!ans.Contains("()"+s1)) ans.Add("()"+s1);
                        if(!ans.Contains(s1+"()")) ans.Add(s1+"()");
                }
            }
            else
            {
                foreach(string s2 in temp2)
                { 
                        if(!ans.Contains("("+s2+")")) ans.Add("("+s2+")");
                        if(!ans.Contains("()"+s2)) ans.Add("()"+s2);
                        if(!ans.Contains(s2+"()")) ans.Add(s2+"()");
                }
            }
        }
        dp[n] = ans.ToList<string>();
        return ans.ToList<string>();
    }
    public IList<string> GenerateParenthesis(int n) {
        dp = new IList<string>[n+1];
        return GenerateParenthesisUtil(n);
    }
}