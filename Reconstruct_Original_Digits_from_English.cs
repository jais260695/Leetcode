public class Solution {
    public string OriginalDigits(string s) {
        int[] countChars = new int[26];
        
        foreach(char ch in s)
        {
            countChars[ch-'a']++;
        }
        
        int[] digitCount = new int[10];
        
        digitCount[0] = countChars['z'-'a'];
        digitCount[2] = countChars['w'-'a'];
        digitCount[4] = countChars['u'-'a'];
        digitCount[6] = countChars['x'-'a'];
        digitCount[8] = countChars['g'-'a'];
        
        digitCount[3] = countChars['h'-'a'] - digitCount[8];
        digitCount[5] = countChars['f'-'a'] - digitCount[4];
        digitCount[7] = countChars['s'-'a'] - digitCount[6];
        
        digitCount[1] = countChars['o'-'a'] - (digitCount[2] + digitCount[4] + digitCount[0]);
        digitCount[9] = countChars['i'-'a'] - (digitCount[6] + digitCount[8] + digitCount[5]);
        
        StringBuilder sb = new StringBuilder();
        
        for(int i=0;i<10;i++)
        {
            for(int j=0;j<digitCount[i];j++)
                sb.Append(i);
        }
        return sb.ToString();
    }
}