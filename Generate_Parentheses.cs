public class Solution {
    Dictionary<int,IList<string>> dp = new Dictionary<int,IList<string>>();
    public IList<string> GenerateParenthesis(int n) {
        if(n==0) return new List<string>();
        if(n==1) return new List<string>(){"()"};
        
        if(dp.ContainsKey(n))
        {
            return dp[n].ToList<string>();
        }
        
        IList<string> ans = new List<string>();
        IList<string> temp1 = new List<string>();
        IList<string> temp2 = new List<string>();
        
        for(int i=0;i<=(n-1)/2;i++)
        {
            temp1.Clear();
            temp1 = GenerateParenthesis(i);
            temp2.Clear();
            temp2 = GenerateParenthesis(n-1-i);
            if(temp1.Count()!=0 && temp2.Count()!=0)
            {
                foreach(string s1 in temp1)
                { 
                    foreach(string s2 in temp2)
                    {
                        string str = "("+s1+")"+s2;
                        if(!ans.Contains(str)) ans.Add(str);
                        str = "("+s2+")"+s1;
                        if(!ans.Contains(str)) ans.Add(str);
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
        dp.Add(n,ans);
        return ans.ToList<string>();
    }
}