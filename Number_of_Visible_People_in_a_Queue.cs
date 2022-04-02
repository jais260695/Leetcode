public class Solution {
    public int[] CanSeePersonsCount(int[] heights) {
        int n = heights.Count();
        Stack<int> st = new Stack<int>();
        st.Push(heights[n-1]);
        heights[n-1] = 0;
        
        for(int i=n-2;i>=0;i--)
        {
            int val = heights[i];
            int c = 0;
            while(st.Count()>0 && st.Peek() < heights[i])
            {
                c++;
                st.Pop();
            }
            
            if(st.Count()>0)
            {
                c++;
            }
            heights[i] = c;
            st.Push(val);
        }
        
        return heights;
    }
}