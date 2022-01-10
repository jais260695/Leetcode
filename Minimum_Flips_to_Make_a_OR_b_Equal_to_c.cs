public class Solution {
    public int MinFlips(int a, int b, int c) {
        int res=0;
       while(a>0 || b>0 || c>0){
           int x = a&1;
           int y = b&1;
           int z = c&1;
           
           if(z==1)
           {
               if(x==0 && y==0) res++;
           }
           else
           {
               if(x==1) res++;
               if(y==1) res++;
           }
           a>>=1;
           b>>=1;
           c>>=1;
       }
       return res;
    }
}