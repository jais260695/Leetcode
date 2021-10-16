public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] ch = new char[s.Length];
        for(int i=0;i<indices.Count();i++)
        {
            ch[indices[i]] = s[i];
        }        
        return new String(ch);
    }
}