public class Solution {
    public int SubtractProductAndSum(int n) {
        int p=1;
        int sum=0;
        while(n!=0)
        {
            p*=n%10;
            sum+=n%10;
            n=n/10;
        }
        return p-sum;
    }
}