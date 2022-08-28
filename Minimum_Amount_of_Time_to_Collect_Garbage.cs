public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int n = garbage.Count();
        
        int result = 0;
        
        int countM = 0;
        int countG = 0;
        int countP = 0;
        
        int distM = 0;
        int distG = 0;
        int distP = 0;
        
        foreach(char ch in garbage[0])
        {
            if(ch=='M') countM++;
            if(ch=='G') countG++;
            if(ch=='P') countP++;
        }
        
        result += (countM + countG + countP);
        
        
        for(int i=1;i<n;i++)
        {
            countM = 0;
            countG = 0;
            countP = 0;

            foreach(char ch in garbage[i])
            {
                if(ch=='M') countM++;
                if(ch=='G') countG++;
                if(ch=='P') countP++;
            }
            
            distM += travel[i-1];
            distG += travel[i-1];
            distP += travel[i-1];
            
            result += (countM + countG + countP);
            
            
            if(countM>0)
            {
                result += distM;
                distM=0;
            }
            
            if(countG>0)
            {
                result += distG;
                distG = 0;
            }
            
            if(countP>0)
            {
                result += distP;
                distP=0;
            }
            
        }
        
        return result;
    }
}