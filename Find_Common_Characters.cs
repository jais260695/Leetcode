public class Solution {
    public IList<string> CommonChars(string[] A) {
        int[] map = new int[26];
        
        for(int i=0;i<26;i++)
        {
            map[i] = int.MaxValue;
        }
        
        foreach(string s in A)
        {
            int[] temp = new int[26];
            foreach(char c in s)
            {
                temp[c-'a']++;
            }
            for(int i=0;i<26;i++)
            {
                map[i] = Math.Min(map[i],temp[i]);
            }
        }

        List<string> res = new List<string>();
        
        for(int i=0;i<26;i++)
        {
            while(map[i]>0)
            {
                res.Add(((char)(i+'a')).ToString());
                map[i]--;
            }
        }
         return res.ToList<string>();   
    }
}