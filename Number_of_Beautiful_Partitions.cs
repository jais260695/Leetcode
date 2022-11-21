public class Solution {
    
    int[,] dp;
    int mod = 1000000007;
    int minLength;
    int n;
    string s;
    HashSet<char> prime = new HashSet<char>();
    public int Solve( int index, int k)
    {
        if(k==0)
        {
            return 0;
        } 
        
        if(dp[index,k]!=-1)
        {
            return dp[index,k];
        }
        
        int result = 0;
        bool isPrevPrime = true;
        
        int i = index+1;
        for(;i<n;i++)
        {
            if(prime.Contains(s[i]))
            {
                if(!isPrevPrime && (i-index)>=minLength)
                {
                    result = (result+ Solve(i,k-1))%mod;
                }
                isPrevPrime = true;
            }
            else
            {
                isPrevPrime = false;
            }
        }
        if(k==1)
        {
            if(!isPrevPrime && (i-index)>=minLength)
            {
                result = (result+ 1)%mod;
            }
        }
 
        dp[index,k] = result;
        return  dp[index,k];
    }

    public int BeautifulPartitions(string s, int k, int minLength) {
        n = s.Length;
        this.s=s;
        this.minLength=minLength;
        dp = new int[n+1,k+1];
        
        for(int i=0;i<=n;i++)
        {
            for(int j=0;j<=k;j++)
            {
                 dp[i,j] = -1;
            }
        }
        prime.Add('2');
        prime.Add('3');
        prime.Add('5');
        prime.Add('7');
        if(!prime.Contains(s[0])) return 0;
        return Solve(0,k);

    }
}