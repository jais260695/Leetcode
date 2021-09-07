public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        int n = words.Count();
        int m = pattern.Length;
        Dictionary<char,List<int>> dict = new Dictionary<char,List<int>>();
        for(int i=0;i<m;i++)
        {
            char ch = pattern[i];
            if(!dict.ContainsKey(ch))
            {
                dict.Add(ch,new List<int>());
            }
            dict[ch].Add(i);
        }
        List<string> ans = new List<string>();
        foreach(string s in words)
        {
            Dictionary<char,List<int>> dict1 = new Dictionary<char,List<int>>();
            for(int i=0;i<m;i++)
            {
                char ch = s[i];
                if(!dict1.ContainsKey(ch))
                {
                    dict1.Add(ch,new List<int>());
                }
                dict1[ch].Add(i);
            }
            if(dict.Count()==dict1.Count())
            {
                bool flag = true;
                for (int i = 0; i < dict.Count; i++)
                {
                    KeyValuePair<char, List<int>> entry = dict.ElementAt(i);
                    KeyValuePair<char, List<int>> entry1 = dict1.ElementAt(i);
                    flag = Enumerable.SequenceEqual(entry.Value, entry1.Value);
                    if(!flag) break;
                }
                if(flag) ans.Add(s);
            }
        }
        return ans.ToList<string>();
    }
}