public class Solution {
    public string CreateString(string s)
    {
        Stack<char> st = new Stack<char>();
        
        StringBuilder _s = new StringBuilder("");
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='#')
            {
                if(st.Count()>0)
                {
                    st.Pop();
                }
            }
            else
            {
                st.Push(s[i]);
            }
        }
        
        while(st.Count()>0)
        {
            _s.Insert(0,st.Pop());
        }
        return _s.ToString();
    }
    public bool BackspaceCompare(string s, string t) {
        return CreateString(s)==CreateString(t);
    }
}