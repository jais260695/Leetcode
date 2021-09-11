public class Solution {
    Dictionary<string,bool> dict = new Dictionary<string,bool>();
    public bool WordBreak(string s, IList<string> wordDict) {
        if(dict.ContainsKey(s)) return dict[s];
        foreach(string str in wordDict)
        {
            int len = str.Length;
            if((len<=s.Length && s.Substring(0,len)==str))
            {
                if(len==s.Length) 
                {
                    dict.Add(s,true);
                    return true;
                }
                if(len<s.Length && WordBreak(s.Substring(len),wordDict))
                {
                    dict.Add(s,true);
                    return true;
                }
            }
        }
        
        dict.Add(s,false);
        return false;
    }
}