public class Solution {
    public int BinarySearch(int left, int right, int[] stones, int key)
    {
        while(left<=right)
        {
            int mid = left + (right -left)/2;
            if(stones[mid]==key)
            {
                return mid;
            }
            else if(stones[mid]>key)
            {
                right = mid-1;
            }
            else{
                left = mid+1;
            }
        }
        return -1;
    }
    
    public Dictionary<int,bool>[] dp;
    
    public bool Solve(int currentIndex, int prevJump, int[] stones, int n)
    {
        if(currentIndex==n-1) return true;

        if(dp[currentIndex].ContainsKey(prevJump))
        {
            return dp[currentIndex][prevJump];
        }
        
        dp[currentIndex].Add(prevJump,false);
        
        
        for(int jump = prevJump-1; jump <= prevJump+1; jump++)
        {
            int nextIndex = BinarySearch(currentIndex+1, n-1, stones, stones[currentIndex]+jump);
            if(nextIndex!=-1)
            {
                if(Solve(nextIndex, jump, stones,n))
                {
                    dp[currentIndex][prevJump] = true;
                    return true;
                }
            }
        }        
        return false;
    }
    public bool CanCross(int[] stones) {
        int n = stones.Count();
        
        dp = new Dictionary<int,bool>[n];
        
        for(int i=0;i<n;i++)
        {
            dp[i] = new Dictionary<int,bool>();
        }
        
        return Solve(0, 0, stones,n);
    }
}