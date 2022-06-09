public class Solution {
    public int[] MaximumBobPoints(int numArrows, int[] aliceArrows) {
        int n = 1<<12;
        int result = 0;
        int mask = 0;
        for(int i=0;i<n;i++)
        {
            int score = 0;
            int arrows = 0;
            
            for(int j=0;j<12;j++)
            {
                int val = 1<<j;
                if((i&val)==val)
                {
                    score+=j;
                    arrows+=(1+aliceArrows[j]);
                }
            }
            
            if(arrows<=numArrows)
            {
                if(score>result)
                {
                    result = score;
                    mask = i;
                }
            }
        }
        
        
        int[] resultArr = new int[12];
        
        result = 0;
        
        for(int j=0;j<12;j++)
        {
            int val = 1<<j;
            if((mask&val)==val)
            {                
                resultArr[j] = 1 + aliceArrows[j];
                result+=resultArr[j];
            }
        }
        
        resultArr[0] = numArrows - result;
        
        return resultArr;
    }
}