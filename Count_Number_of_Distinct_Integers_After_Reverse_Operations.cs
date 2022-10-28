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
    public int CountDistinctIntegers(int[] nums) {
        int n = nums.Count();
        HashSet<int> dict = new HashSet<int>();
        
        for(int i=0;i<n;i++)
        {
            int reversedNum = ReverseInt(nums[i]);
            
            
            dict.Add(nums[i]);
            dict.Add(reversedNum);
        }
        

        return dict.Count();
    }
}