public class Solution {
    public string OrderlyQueue(string s, int k) {
        if(k>1)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);            
            return new String(charArray);
        }
        int n = s.Length;
            
        string result = s;

        for(int i=1;i<n;i++)
        {
            string newS = s.Substring(i) + s.Substring(0,i);
            if(result.CompareTo(newS)>0)
            {
                result = newS;
            }
        }
        
        return result;
    }
}