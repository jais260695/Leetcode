public class Solution {
    Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();
    public IList<string> WordBreakUtil(string s, IList<string> wordDict) { 
        
        List<string> res = new List<string>();
        foreach(string str in wordDict)
        {
            int len = str.Length;
            if(s.StartsWith(str))
            {
                if(len==s.Length)
                {
                    res.Add(str);
                }
                else if(len<s.Length)
                {
                    string temp = s.Substring(len);
                    if(!dict.ContainsKey(temp))
                    {
                        WordBreakUtil(temp,wordDict);
                    }
                    
                    foreach(string d in dict[temp])
                    {
                        res.Add(str+ " " + d);
                    }
                }
            }
        }
        
        dict.Add(s,res);
        
        return res.ToList<string>();
        
    }
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        return WordBreakUtil(s,wordDict);
    }
}