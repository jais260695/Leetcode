public class Solution {        
    int[,] dp = new int[5,51];
    public int CountStrings(int n, int index)
    {
        if(n==0) return 1;        
        if(dp[index,n]>0) return dp[index,n];
        int c = 0;
        for(int i=index;i<5;i++)  
        {
            c+=CountStrings(n-1,i);  
        }
        return dp[index,n] = c;
    }
    public int CountVowelStrings(int n) {
        return CountStrings(n,0);
    }
}