public class Solution {
    public IList<string> WordSubsets(string[] A, string[] B) {
        int[] arrMax = new int[26];
        
        foreach(string b in B)
        {
            int[] temp = new int[26];
            foreach(char ch in b)
            {
                temp[ch-'a']++;
            }
            
            for(int i=0;i<26;i++)
            {
                arrMax[i] = Math.Max(arrMax[i],temp[i]);
            }
        }
        
        List<string> result = new List<string>();
        
        foreach(string a in A)
        {
            int[] temp = new int[26];
            foreach(char ch in a)
            {
                temp[ch-'a']++;
            }
            int i=0;
            for(;i<26;i++)
            {
                if(temp[i]<arrMax[i])
                {
                    break;
                }
            }
            
            if(i==26)
            {
                result.Add(a);
            }
        }
        
        return result.ToList<string>();
    }
}