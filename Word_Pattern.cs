public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] sArr = s.Split(' ');
        int n = pattern.Length;
        int m = sArr.Count();
        if(n!=m) return false;
        Dictionary<char,string> dict = new Dictionary<char,string>();
        HashSet<string> hSet = new HashSet<string>();
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(pattern[i]))
            {
                if(hSet.Contains(sArr[i])) return false;
                dict.Add(pattern[i],sArr[i]);
                hSet.Add(sArr[i]);
            }
            else
            {
                if(dict[pattern[i]]!=sArr[i]) return false;
            }
        }
        return true;
    }
}