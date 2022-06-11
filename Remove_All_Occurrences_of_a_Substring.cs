public class Solution {
    public string RemoveOccurrences(string s, string part) {
        int n = s.Length;
        int m = part.Length;
        string stemp = string.Empty;
        for(int i=0;i<n;i++)
        {
            stemp += s[i];
            while(stemp.Contains(part))
            {
                stemp = stemp.Substring(0,stemp.Length-m);
            }
        }
        
        return stemp;
    }
}