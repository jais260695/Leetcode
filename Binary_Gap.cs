public class Solution {
    public int BinaryGap(int n) {
        int i = 0,j=0;
        int ans = 0;
        while(n>0)
        {
            int val = n&1;
            n=n>>1;
            if(val==1)
            {
                break;
            }
            
            i++;
        }
        j = i+1;
        while(n>0)
        {
            int val = n&1;
            n=n>>1;
            if(val==1)
            {
                ans = Math.Max(ans,j-i);
                i = j;
            } 
            j++;
        }
        return ans;
    }
}