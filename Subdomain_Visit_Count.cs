public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string,int> dict  = new  Dictionary<string,int>();
        int n = cpdomains.Length;
        for(int i=0;i<n;i++)
        {
            string[] t = cpdomains[i].Split(' ');
            int count = Convert.ToInt32(t[0]);
            string[] str = t[1].Split('.');
            int m = str.Length;
            string temp = "";
            for(int j=m-1;j>=0;j--)
            {
                temp=str[j]+temp;
                if(!dict.ContainsKey(temp)) dict.Add(temp,0);
                dict[temp]+=count;
                temp="."+temp;
            }
        }
        List<string> result = new List<string>();
        foreach(KeyValuePair<string,int> kvp in dict)
        {
            result.Add(kvp.Value+" "+kvp.Key);
        }
        return result.ToList<string>();
    }
}