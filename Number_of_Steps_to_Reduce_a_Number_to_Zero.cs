public class Solution {
    public int NumberOfSteps (int num) {
        int result=0;
        while(num!=0)
        {
            result++;
            if(num%2==0)
            {
                num = num/2;
            }
            else
            {
                num--;
            }
        }
        return result;
    }
}