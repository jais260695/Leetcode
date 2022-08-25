public class Solution {
    public int TupleSameProduct(int[] nums) {
        int n = nums.Count();
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int result=0;
        for(int i=0;i<n-1;i++)
        {
            for(int j= i+1; j<n;j++)
            {
                int val = nums[i]*nums[j];
                if(!dict.ContainsKey(val) )
                {
                    dict.Add(val,0);
                }
                result += 8*dict[val];
                dict[val]++;
            }
        } 
          
        return result;
        
    }
}