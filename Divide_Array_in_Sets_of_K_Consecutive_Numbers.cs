public class Solution {
    public bool IsPossibleDivide(int[] hand, int groupSize) {
        int n = hand.Count();
        if(n%groupSize!=0) return false;
        Array.Sort(hand);
        int result = 0;
        
        for(int i=0;i<n;i++)
        {
            if(hand[i]==-1) continue;
            int count = 1;
            int val = hand[i]+1;
            hand[i] = -1;
            int j = i+1;
            while(j<n && count<groupSize)
            {
                if(hand[j]!=-1 && hand[j]==val)
                {
                    count++;
                    val = hand[j]+1;
                    hand[j] = -1;
                }
                
                j++;
            }
            
            if(count==groupSize) result++;

        }
        
        return result == n/groupSize;
    }
}