public class Solution {
    public string FreqAlphabets(string s) {
        int n = s.Length;
        int i = n-1;
        string str ="";
        while(i>=0)
        {
            if(s[i]=='#')
            {
                int val = Convert.ToInt32(s.Substring(i-2,2));
                str = str.Insert(0,((char)(96 + val)).ToString());
                i=i-3;
            }
            else
            {
                int val = Convert.ToInt32(s[i].ToString());
                str = str.Insert(0,((char)(96 + val)).ToString());
                i = i-1;
            }
        }
        return str;
    }
}