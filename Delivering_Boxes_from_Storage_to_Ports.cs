public class Solution {
    int[] dp ;
    int maxBoxes;
    int maxWeight;
    int n;
    public int Deliever(int start, int[][] boxes)
    {
        if(start==n) return 0;
        if(dp[start]!=0) return dp[start];
        List<int> ports = new List<int>();
        int noOfBoxes = 0;
        int weight = 0;
        int i=start;
        
         //fill the ship until maximum limit is reached
        while(i<n && noOfBoxes+1<=maxBoxes &&   weight+boxes[i][1]<=maxWeight)
        {
            noOfBoxes++;
            weight+=boxes[i][1];
            if(ports.Count()==0 || ports[ports.Count()-1]!=boxes[i][0])
            {
                ports.Add(boxes[i][0]);
            }
            i++;
            
        }
        dp[start] = 1 + ports.Count() + Deliever(i,boxes) ;
        
        //Now check if the ith port(not on ship) is same as imeediate previous box ports(loaded on ship) then try to send the continous same port boxes together or unload them from the ship and load them together with ith box after trip
        if(i<n)
        {
            while(i>start && boxes[i][0]==boxes[i-1][0])
            {
                if(ports.Count()>0 && ports[ports.Count()-1]==boxes[i][0])
                {
                    ports.RemoveAt(ports.Count()-1);
                }
                i--;
            }
            if(i>start)
            {
                dp[start] = Math.Min(dp[start],1 + ports.Count() + Deliever(i,boxes) );
            }
        }
        
        return dp[start] ;
    }
    public int BoxDelivering(int[][] boxes, int portsCount, int maxBoxe, int maxWeigh) {
        n = boxes.Count();
        maxBoxes = maxBoxe;
        maxWeight = maxWeigh;
        dp = new int[n];
        return Deliever(0,boxes);
    }
}