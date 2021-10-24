public class Solution {
    public int RepeatedNTimes(int[] A) {
        int n = (A.Count()/2+1);
        Dictionary<int,int> dp = new Dictionary<int,int>();
        
        for(int i=0;i<A.Count();i++)
        {
            if(!dp.ContainsKey(A[i]))
                dp.Add(A[i],0);
            dp[A[i]]++;
            if(dp[A[i]]>1) return A[i];
        }
        return -1;
    }
}