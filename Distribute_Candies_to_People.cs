public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int i =0;
        int[] result = new int[num_people];
        int can = 0;
        while(true)
        {
            int val = i+1;   
            can += val;
            if(can>candies)
            {
                val = candies - (can - val) ;
                result[i%num_people] += val ;
                break;
                    
            }
            result[i%num_people] += val  ;
            i++;
        }
        return result;
    }
}