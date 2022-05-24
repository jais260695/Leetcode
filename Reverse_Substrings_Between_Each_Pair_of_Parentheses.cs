public class Solution {
    public string ReverseParentheses(string s) {
        int n = s.Length;
        Stack<char> st = new Stack<char>();
        
        for(int i=0;i<n;i++)
        {
            if(s[i]==')')
            {
                Queue<char> temp = new Queue<char>();
                while(st.Count()>0)
                {
                    char ch = st.Pop();
                    if(ch=='(') break;
                    temp.Enqueue(ch);
                }
                
                while(temp.Count()>0)
                {
                    st.Push(temp.Dequeue());
                }
            }
            else
            {
                st.Push(s[i]);
            }
        }
        
        StringBuilder sb = new StringBuilder();
        
        while(st.Count()>0)
        {
            sb.Insert(0,st.Pop());
        }
        
        return sb.ToString();
    }
}