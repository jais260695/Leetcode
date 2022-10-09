public class Solution {
    public string RobotWithString(string s) {
        int n = s.Length;
        int[] dp = new int[n];
        
        dp[n-1] = n-1;
        
        char prev  = s[n-1];
        
        for(int i=n-2;i>=0;i--)
        {
            if(s[i]>=prev)
            {
                dp[i] = dp[i+1];
            }
            else
            {
                dp[i] = i;
                prev  = s[i];
            }
        }
        
        StringBuilder sb = new StringBuilder();
        
        int j = 0;
        
        Stack<int> st = new Stack<int>();
        
        while(j<n)
        {
            
            if(dp[j]==j)
            {
                while(st.Count()>0 && s[st.Peek()] <= s[dp[j]])
                {
                    sb.Append(s[st.Pop()]);
                }
                
                sb.Append(s[j]);
                
                while(st.Count()>0 && s[st.Peek()] == s[j])
                {
                    sb.Append(s[st.Pop()]);
                }
            }
            
            if(dp[j]>j)
            {
                while(st.Count()>0 && s[st.Peek()] <= s[dp[j]])
                {
                    sb.Append(s[st.Pop()]);
                }
                
                st.Push(j);
            }
            
            j++;
            
            
        }
        
        while(st.Count()>0)
        {
            sb.Append(s[st.Pop()]);
        }
        
        return sb.ToString();
    }
}