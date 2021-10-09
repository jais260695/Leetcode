public class Solution {
    public int ReinitializePermutation(int n) {
        int i=n-2;
        int ans = 0;
        do
        {
            ans++;
            i = i%2==0 ? i/2 : (n+i-1)/2;
        }
        while(i!=n-2);
        return ans;
    }
}