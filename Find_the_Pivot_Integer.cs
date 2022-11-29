public class Solution {
    public int PivotInteger(int n) {
        int sum = (n*(n+1))/2;
        int temp = 0;
        for(int i=1;i<=n;i++)
        {
            temp+=i;
            int prev = sum - ((i-1)*(i))/2;
            if(temp==prev)
            {
                return i;
            }
        }
        
        return -1;
    }
}