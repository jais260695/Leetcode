public class Solution {
    public int MinSteps(string s, string t) {
        int[] count = new int[26];
        
        foreach(var ch in s)
        {
            count[ch-'a']++;
        }
                
        foreach(var ch in t)
        {
            count[ch-'a']--;
        }
        
        int result = 0;
        for(int i=0;i<26;i++)
        {
            result+=Math.Abs(count[i]);
        }
        
        return result;
    }
}