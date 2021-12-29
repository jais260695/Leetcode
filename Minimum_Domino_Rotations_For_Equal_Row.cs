public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        int n = A.Count();
        
        int[] diceCount = new int[7];        
        int maxA = -1;
        int countA = 0;        
        for(int i=0;i<n;i++)
        {
            diceCount[A[i]]++;
            if(diceCount[A[i]]>countA)
            {
                maxA = A[i];
                countA = diceCount[A[i]];
            }
        }
        if(countA==n) return 0;
        
        diceCount = new int[7];
        int maxB = -1;
        int countB = 0;       
        for(int i=0;i<n;i++)
        {
            diceCount[B[i]]++;
            if(diceCount[B[i]]>countB)
            {
                maxB = B[i];
                countB = diceCount[B[i]];
            }
        }
        if(countB==n) return 0;  
        
        int resA = 0;
        int resB = 0;
        
        for(int i=0;i<n;i++)
        {
            if(A[i]!=maxA && B[i]==maxA) resA++;
            if(B[i]!=maxB && A[i]==maxB) resB++;
        }
        
        int res = int.MaxValue;
        if(countA + resA==n) res = Math.Min(res,resA);
        if(countB + resB==n) res = Math.Min(res,resB);        
        return res==int.MaxValue?-1:res;
    }
}