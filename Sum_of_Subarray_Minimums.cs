public class Solution {
    public int SumSubarrayMins(int[] arr) {
        int n = arr.Count();
        int[] prefix = new int[n];
        int[] suffix = new int[n];
        
        int mod = 1000000007;
        long result = 0;
        
        Stack<int> st = new Stack<int>();
        
        int i=0;
        while(i<n)
        {
            while(st.Count()>0 && arr[st.Peek()]>arr[i])
            {                
                suffix[st.Peek()] = i;
                st.Pop();
            }
            
            prefix[i] = st.Count()==0 ? -1 : st.Peek();
            st.Push(i);
            i++;
        }
        
        while(st.Count()>0)
        {
            suffix[st.Pop()] = n;           
        }

        
        i=0;
        for(;i<n;i++)
        {
            int left = Math.Abs(i-prefix[i]);
            int right = Math.Abs(suffix[i]-i);
            
            long combinations = (left*right)%mod;
            
            result = (result +  (combinations*arr[i]))%mod;
        }
        
        return Convert.ToInt32(result);
    }
}