public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        int n = s.Length;
        if(n==1) return false;
        for(int i=0;i<n;i++)
        {
            if(s[i]=='(' || s[i]=='{' || s[i]=='[')
            {
                st.Push(s[i]);
            }
            else
            {
                if(st.Count()==0) return false;
                char ch = st.Pop();
                
                if(ch=='(' && s[i]==')')
                {
                    continue;
                }
                else if(ch=='{' && s[i]=='}')
                {
                    continue;
                }
                else if(ch=='[' && s[i]==']')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        if(st.Count()==0)
            return true;
        return false;
    }
}