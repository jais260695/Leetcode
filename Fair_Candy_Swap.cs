public class Solution {
    public int[] FairCandySwap(int[] A, int[] B) {
        int a = A.Count();
        int b = B.Count();
        int sumA = 0 ;
        for(int i =0;i<a;i++)
        {
            sumA += A[i];
        }
        
        int sumB = 0 ;
        for(int i =0;i<b;i++)
        {
            sumB += B[i];
        }
        
        int[] ans = new int[2];
        
        for(int i = 0;i<a;i++)
        {
            for(int j = 0;j<b;j++)
            {
                if(sumA-A[i]+B[j] == sumB-B[j]+A[i])
                {
                    ans[0] = A[i];
                    ans[1] = B[j];
                    return ans;
                }
            }
        }
        return ans;
    }
}