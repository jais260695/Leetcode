public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        HashSet<string> hSet = new HashSet<string>();
        int n = s.Length;
        List<string> result = new List<string>();
        for(int i=0;i<n-9;i++)
        {
            string temp = s.Substring(i,10);
            if(hSet.Contains(temp) && !result.Contains(temp))
            {
                result.Add(temp);
            }
            hSet.Add(temp);
        }
        return result.ToList<string>();
    }
}