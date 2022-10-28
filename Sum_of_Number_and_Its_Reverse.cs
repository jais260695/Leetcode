public class Solution {
    int ReverseInt(int num)
    {
        int reversedNum = 0;
        
        while(num>0)
        {
            reversedNum*=10;
            reversedNum+=(num%10);
            num/=10;
                
        }
        
        return reversedNum;
    }
    public bool SumOfNumberAndReverse(int num) {
        for(int i=0;i<=num;i++)
        {
            int reverse = ReverseInt(i);
            
            if((i+reverse)==num) return true;
            
        }
        
        return false;
    }
}