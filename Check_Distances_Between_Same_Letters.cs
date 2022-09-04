public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        Dictionary<char,int> letters = new Dictionary<char,int>();
        
        for(int i = 0; i< s.Length; i++)
        {
            if(!letters.ContainsKey(s[i]))
            {
                letters.Add(s[i],i);
            }
            else
            {
                if(i-letters[s[i]] != distance[s[i]-'a']+1) return false;
            }
        }
        
        return true;
    }
}