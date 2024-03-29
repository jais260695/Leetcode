public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(char ch in s)
        {
            if(!dict.ContainsKey(ch))
            {
                dict.Add(ch,0);
            }
            dict[ch]++;
        }
        StringBuilder ans = new StringBuilder();
        var map = dict.OrderByDescending(kvp => kvp.Value);
        foreach(KeyValuePair<char,int> kvp in map)
        {
            for(int i=0;i<kvp.Value;i++)
            {
                ans.Append(kvp.Key);
            }
        }
        return ans.ToString();
    }
}