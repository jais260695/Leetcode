public class Solution {
    int Primefactors(int n)
    {
        if(n==0) return 0;
        
        int newN = 0;
        while(n%2==0)
        {
            newN+=2;
            n=n/2;
        }
        
        for(int i=3;i<=Math.Sqrt(n);i+=2)
        {
            while(n%i==0)
            {
                newN+=i;
                n=n/i;
            }
        }
        
        if(n>2) newN+=n;
        
        
        return newN;
    }
    public int SmallestValue(int n) {
        int newN = Primefactors(n);
        return n==newN ? n : SmallestValue(newN);
    }
}