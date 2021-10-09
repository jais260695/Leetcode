public class Solution {
    public string Evaluate(string s, IList<IList<string>> knowledge) {
        int n = s.Length;
        Dictionary<string,string> map = new Dictionary<string,string>();
        foreach(List<string> l in knowledge)
        {
            map.Add(l[0],l[1]);
        }
        int i=0;
        string ans = "";
        while(i<n)
        {
            if(s[i]=='(')
            {
                int j = i+1;
                while(s[i]!=')')
                {
                    i++;
                }
                if(map.ContainsKey(s.Substring(j,i-j)))
                {
                    ans+=map[s.Substring(j,i-j)];
                }
                else
                {
                    ans+='?';
                }
            }
            else
            {
                ans+=s[i];
            }
            i++;
        }
        return ans;
    }
}