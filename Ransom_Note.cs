public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] dict = new int[26];
        foreach(char ch in ransomNote)
        {
            dict[ch-'a']++;
        }      
        foreach(char ch in magazine)
        {
            dict[ch-'a']--;
        }
        
        for(int i=0;i<26;i++)
        {
            if(dict[i]>0) return false;
        }
        return true;
    }
}