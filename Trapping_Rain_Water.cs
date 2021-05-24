public class Solution {
    public int Trap(int[] height) {
        int n = height.Count();
        if(n<=1) return 0;
        Stack<int> st = new Stack<int>();
        st.Push(0);
        int result = 0;
        while(true)
        {
            int i = st.Peek();
            if(i==n-1) break;
            int j=i+1;
            int max = int.MinValue;
            int maxIndex = j;
            while(j<n)
            {
                if(height[j]>=height[i])
                {
                    maxIndex = j;
                    break;
                }
                
                if(height[j]>=max)
                {
                    maxIndex  = j;
                    max = height[j];
                }
                j++;
            }
            
            j = maxIndex;
            int cap = Math.Min(height[i],height[j]);
            
            for(int k = i+1;k<j;k++)
            {
                result += cap-height[k];
            }
            
            st.Pop();
            st.Push(j);
        }
        return result;
    }
}