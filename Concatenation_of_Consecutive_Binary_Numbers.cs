public class Solution {
    public int ConcatenatedBinary(int n) {
        int temp = 1;
        int mod = 1000000007;
        for(int i=2;i<=n;i++)
        {
            int d = (int)Math.Log(i,2)+1;            
            while(d>0)
            {
                temp = (temp<<1)%mod;
                d--;
            }
            temp = (temp+i)%mod;
        }        
        return temp;
    }
}