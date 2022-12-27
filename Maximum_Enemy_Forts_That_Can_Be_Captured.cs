public class Solution {
    public int CaptureForts(int[] forts) {
        int n = forts.Count();
        
        int result = 0;
        
        int zeroes = 0;
        bool isEnemy = false;
        bool isOne = false;
        for(int i=0;i<n;i++)
        {
            if(forts[i]==-1)
            {
                isEnemy=true;
                if(isOne)
                {
                    result=Math.Max(zeroes,result);
                }
                isOne=false;
                zeroes=0;
            }
            if(forts[i]==1)
            {
                isOne=true;
                if(isEnemy)
                {
                    result=Math.Max(zeroes,result);
                }
                isEnemy=false;
                zeroes=0;
            }
            if(forts[i]==0) zeroes++;
        }
        
        return result;
    }
}