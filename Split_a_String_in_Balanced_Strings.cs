public class Solution {
    public int BalancedStringSplit(string s) {
        
        int result = 0;
        int sum = 0;
        foreach(char ch in s)
        {
            if(ch=='L')
            {
                sum+=1;
            }
            else
            {
                sum-=1;
            }
            if(sum==0)
                result++;
        }
        return result;
        
    }
}