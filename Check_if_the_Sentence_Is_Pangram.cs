public class Solution {
    public bool CheckIfPangram(string sentence) {
        int[] alpha = new int[26];
        foreach(char ch in sentence)
        {
            alpha[ch-'a']++;
        }
        
        for(int i=0;i<26;i++)
        {
            if(alpha[i]==0) return false;
        }
        return true;
    }
}