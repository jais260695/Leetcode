public class Solution {
    public string StrNoVowel(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        
        List<char> vowels = new List<char>(){'a','e','i','o','u'};
        
        for(int i=0;i<s.Length;i++)
        {
            if(vowels.Contains(s[i]))
            {
                sb[i] = '1';
            }
        }
        return sb.ToString();
    }
    public string[] Spellchecker(string[] wordlist, string[] queries) {
        int n = queries.Count();
        Dictionary<string,string> dict = new Dictionary<string,string>();
        Dictionary<string,string> dict1 = new Dictionary<string,string>();
        foreach(string s in wordlist)
        {
            if(!dict1.ContainsKey(s))
            {
                dict1.Add(s,s);
            }
            string strLower = s.ToLower();
            if(!dict.ContainsKey(strLower))
            {
                dict.Add(strLower,s);
            }
            string strNoVowel = StrNoVowel(strLower);
            if(!dict.ContainsKey(strNoVowel))
            {
                dict.Add(strNoVowel,s);
            }
        }
        string[] result = new string[n];
        for(int i=0;i<n;i++)
        {
            string strLower = queries[i].ToLower();
            string strNoVowel = StrNoVowel(strLower);
            if(dict1.ContainsKey(queries[i]))
            {
                result[i] = dict1[queries[i]];
            }
            else if(dict.ContainsKey(strLower))
            {
                result[i] = dict[strLower];
            }
            else if(dict.ContainsKey(strNoVowel))
            {
                result[i] = dict[strNoVowel];
            }
            else
            {
                result[i] = "";
            }
        }
        return result;
    }
}