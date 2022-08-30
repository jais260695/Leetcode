public class Solution {
    Dictionary<int,int> dp = new Dictionary<int,int>();
    public int FindPower(int val)
    {
        if(val==1) return 0;
        
        if(dp.ContainsKey(val)) return dp[val];
        
        int result = 1;
        
        if(val%2==0)
        {
            result+=FindPower(val/2);
        }
        else
        {
            result+=FindPower(3*val+1);
        }
        
        dp.Add(val, result);
        return dp[val];
    }
    public int GetKth(int lo, int hi, int k) {
        int[][] arr = new int[hi-lo+1][];
        
        int i = 0;
        while(lo<=hi)
        {
            arr[i] = new int[2];
            arr[i][0] = lo;
            arr[i][1] = FindPower(lo);
            i++;
            lo++;
        }
        
        Array.Sort(arr,delegate(int[] t1,int[] t2){
            if(t1[1]!=t2[1])
            {
                return t1[1]-t2[1];
            }
            
            return t1[0] - t2[0];
        });
        
        return arr[k-1][0];
    }
}