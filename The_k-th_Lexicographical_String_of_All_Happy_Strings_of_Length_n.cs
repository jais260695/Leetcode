public class Solution {
    int K;
    char[] ch = new char[3]{'a','b','c'};
    public string Solve(char prev,int n)
    {
        if(n==0) 
        {
            K--;
            return string.Empty;
        }
        string str = string.Empty;          
        for(int i=0;i<3;i++)
        {
            if(prev!=ch[i])
            {
                str = ch[i] + Solve(ch[i],n-1);
                if(K==0) return str;
            }       
        }        
        return string.Empty;
    }
    public string GetHappyString(int n, int k) {
        K=k;
        return Solve('$',n);
    }
}