public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> st = new Stack<string>();
        int count = 0;
        int n = path.Count();
        int i = 0;
        StringBuilder sb;
        while(i<n)
        {
            sb = new StringBuilder();
            if(path[i]=='/')
            {
                i++;
                while(i<n && path[i]!='/')
                {
                    sb.Append(path[i]);
                    i++;
                }
            }

            if(sb.ToString()==".") continue;

            if(sb.ToString()=="..")
            {
                
                if(st.Count()>0)
                {
                    while(st.Count()>0 && st.Peek()=="") st.Pop();
                    if(st.Count()>0)
                        st.Pop();
                }
                continue;
            } 
            st.Push(sb.ToString());
        }
        
        StringBuilder ans = new StringBuilder();
        while(st.Count()>0)
        {
            if(st.Peek()=="") 
            {
                st.Pop();
                continue;
            }
            ans.Insert(0,st.Pop());
            ans.Insert(0,"/");
        }
        return ans.ToString()=="" ? "/": ans.ToString();
    }
}