public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Count();
        int[] res = new int[n];
        Stack<int> st = new Stack<int>();
        st.Push(n-1);
        res[n-1] = 0;
        for(int i=n-2;i>=0;i--)
        {
            while(st.Count()>0 && temperatures[st.Peek()]<=temperatures[i])
            {
                st.Pop();
            }
            if(st.Count()==0)
            {
                res[i] = 0;
            }
            else
            {
                res[i] = st.Peek()-i;
            }
            
            st.Push(i);
        }
        
        return res;
    }
}