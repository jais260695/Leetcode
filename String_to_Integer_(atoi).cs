public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        
        int n = s.Length;
        int i = 0;
        int sign = 1;
        
        if (i < n && (s[i] == '-' || s[i] == '+'))
        {
            sign = s[i] == '-' ? -1 : 1;
            i++;
        }
        
        
        int ans = 0;
        
        while (i<n && s[i] >= '0' && s[i] <= '9') 
        {
            int temp = s[i] - '0';
            
            if((ans >  int.MaxValue/10) || ( ans == int.MaxValue/10 && temp>=8 ))
            {
                return sign==-1 ? int.MinValue : int.MaxValue;
            }
            
            
            ans  = 10 * ans + temp;
            i++;
        }
        ans = sign*ans;
        
        return (int)ans;
    }
}