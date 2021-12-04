public class Solution {
    public int LongestOnes(int[] A, int K) {
        int count=0,j=-1,ans=0;
        for(int i=0;i<A.Count();i++)
        {
            if(A[i]==0) 
            {
                count++;
                if(count>K)
                {
                    do
                    {
                        j++;
                    }
                    while(A[j]!=0);
                    count--;
                }
            }
            if(ans<(i-j))
                ans = i-j;
        }
        return ans;
    }
}