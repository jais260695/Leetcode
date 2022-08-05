public class Solution {
    public int GCD(int p, int q)
    {
        if(p==0) return q;
        
        if(p>=q) return GCD(p-q,q);
        else
        {
            return GCD(q-p,p);
        }
    }
    public int MirrorReflection(int p, int q) {
        
        int height = (p*q)/GCD(p,q);
        
        int length = (height*p)/q;
        
        int H = height/p;
        H--;
        
        int L = length/p;
        L--;
        
        
        int top = 1;
        int bottom = 0;
        if(L%2!=0)
        {
            top = 2;
            bottom = -1;
        }
        
        if(H%2!=0)
        {
            return bottom;
        }
        
        return top;
    }
}