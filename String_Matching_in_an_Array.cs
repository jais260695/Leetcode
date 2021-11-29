public class Solution {
    public IList<string> StringMatching(string[] words) {
        int n = words.Length;
        List<string> result = new List<string>();
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(words[i].Contains(words[j]))
                {
                    if(!result.Contains(words[j]))
                        result.Add(words[j]);
                    continue;
                }
                if(words[j].Contains(words[i]))
                {
                    if(!result.Contains(words[i]))
                        result.Add(words[i]);
                }
            }
        }
        return result.ToList<string>();
    }
}