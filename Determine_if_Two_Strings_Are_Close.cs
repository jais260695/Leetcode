public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length!=word2.Length) return false;

        int[] word1Freq = new int[26];
        int[] word2Freq = new int[26];

        for(int i=0;i<word1.Length;i++)
        {
            word1Freq[word1[i]-'a']++;
            word2Freq[word2[i]-'a']++;
        }

        for(int i=0;i<26;i++)
        {
            if((word1Freq[i]==0 && word2Freq[i]>0) || (word2Freq[i]==0 && word1Freq[i]>0))
            {
                return false;
            }
        }

        Array.Sort(word1Freq);
        Array.Sort(word2Freq);

        for(int i=0;i<26;i++)
        {
            if(word1Freq[i]!=word2Freq[i])
            {
                return false;
            }
        }

        return true;
    }
}