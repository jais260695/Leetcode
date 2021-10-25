public class Solution {
    public string MinRemoveToMakeValid(string s) {
        StringBuilder sb = new StringBuilder();
        int n = s.Length;
        Stack<int> st = new Stack<int>();
        for(int i=0;i<n;i++)
        {
            if(s[i]==')')
            {
                if(st.Count()==0)
                {
                    continue;
                }
                else
                {
                    st.Pop();
                    sb.Append(s[i]);
                }
            }
            else if(s[i]=='(')
            {
                st.Push(sb.Length);
                sb.Append(s[i]);
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        while(st.Count()>0)
        {
            int i = st.Pop();
            sb.Remove(i,1);
        }
        return sb.ToString();
    }
}