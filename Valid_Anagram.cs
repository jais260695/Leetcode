public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] chars = new int[26];
        foreach(char ch in s)
        {
            chars[ch-'a']++;
        }
        foreach(char ch in t)
        {
            chars[ch-'a']--;
        }
        for(int i=0;i<26;i++)
        {
            if(chars[i]!=0) return false;
        }
        return true;
    }
}