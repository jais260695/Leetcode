public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        int n = pushed.Count();
        int i = 0;
        int j = 0;
        
        Stack<int> st = new Stack<int>();
        
        while(i<n && j<n)
        {
            while(i<n && pushed[i]!=popped[j])
            {
                st.Push(pushed[i]);
                i++;
            }
            
            if(i<n)
            {
                int t = j+1;
                while(st.Count()>0 && t<n && st.Peek()==popped[t])
                {
                    st.Pop();
                    t++;
                }
                
                i++;
                j = t;
            }

        }
        
        return st.Count()==0 ;
    }
}