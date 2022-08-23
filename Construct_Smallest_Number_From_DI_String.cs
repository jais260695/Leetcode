public class Solution {
    Stack<int> st;
    int n;
    bool[] visited = new bool[10];
    public bool Solve(string pattern , int index)
    {
        if(index==pattern.Length)
        {
            return true;
        }
        
        if(pattern[index]=='I')
        {
            for(int i=1;i<=9;i++)
            {
                if(i>st.Peek() && !visited[i])
                {
                    visited[i] = true;
                    st.Push(i);
                    if(Solve(pattern,index+1))
                    {
                        return true;
                    }
                    
                    st.Pop();
                    visited[i] = false;
                }
            }
        }
        
        if(pattern[index]=='D')
        {
            for(int i=1;i<=9;i++)
            {
                if(i<st.Peek() && !visited[i])
                {
                    visited[i] = true;
                    st.Push(i);
                    if(Solve(pattern,index+1))
                    {
                        return true;
                    }
                    
                    st.Pop();
                    visited[i] = false;
                }
            }
        }
        
        return false;
    }
    public string SmallestNumber(string pattern) {
        n = pattern.Length;
        st = new Stack<int>();
        
        for(int i=1;i<=9;i++)
        {
            visited[i] = true;
            st.Push(i);
            if(Solve(pattern,0)) break;
            st.Pop();
            visited[i] = false;
        }
        
        StringBuilder result = new StringBuilder();
        
        while(st.Count()>0)
        {
            result.Insert(0,st.Pop());
        }
        
        return result.ToString();
    }
}