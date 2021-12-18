public class Solution {
    public string SmallestSubsequence(string s) {        
        Dictionary<char,int> dict = new Dictionary<char,int>();
        Dictionary<char,bool> visited = new Dictionary<char,bool>();
        int n = s.Length;
        int i;
        for(i = n-1 ;i>=0;i--)
        {
            if(!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i],i);
                visited.Add(s[i],false);
            }
        }      
        Stack<char> st = new Stack<char>();        
        i = 0;
        while(i<n)
        {
            if(st.Count()==0)
            {
                st.Push(s[i]);
                visited[s[i]] = true;
                i++;
            }
            else if(st.Peek()>s[i] && !visited[s[i]])
            {
                if(dict[st.Peek()]>i)
                {
                    visited[st.Peek()] = false;
                    st.Pop();
                }
                else
                {
                    st.Push(s[i]);
                    visited[s[i]] = true;
                    i++;
                }
            }
            else if(st.Peek()<s[i] && !visited[s[i]])
            {
                st.Push(s[i]);
                visited[s[i]] = true;
                i++;
            }
            else i++;
        }
        string res = "";
        Console.WriteLine(st.Count());
        while(st.Count()>0)
        {
            res = res.Insert(0,st.Pop().ToString());
        }
        return res;        
    }
}