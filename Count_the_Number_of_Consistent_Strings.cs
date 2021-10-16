public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int c = 0;
        int n = words.Count();
        foreach(string str in words)
        {
            foreach(char ch in str)
            {
                if(!allowed.Contains(ch))
                {
                    c++;
                    break;
                }
            }
        }
        return n-c;
    }
}