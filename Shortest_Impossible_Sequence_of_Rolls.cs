public class Solution {
    int FindJustGreater(int l, int r, int pivot, List<int> nums)
    {
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            
            if(nums[mid]>pivot)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        
        return l;
    }
    
    public int ShortestSequence(int[] rolls, int k) {
        int n = rolls.Count();
        
        Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
        
        for(int i=1; i<=k; i++)
        {
            dict.Add(i,new List<int>());
        }
        
        for(int i=0; i<n; i++)
        {   
            dict[rolls[i]].Add(i);
        }
        
        int[] indexTrack = new int[k+1];
        int result = 1;
        int prevMax = int.MinValue;
        
        while(result <= n)
        {
            int currMin = int.MaxValue;
            int currMax = int.MinValue;
            
            for(int i=1; i<=k; i++)
            {                
                int j = FindJustGreater(indexTrack[i], dict[i].Count()-1, prevMax, dict[i]);               
                
                if(j == dict[i].Count()) return result;
                
                currMin = Math.Min(currMin, dict[i][j]);
                currMax = Math.Max(currMax, dict[i][j]);
                                
                indexTrack[i] = j;                
            }
            
            if(currMin < prevMax)
            {
                return result;
            }
                
            prevMax = currMax;
            result++;
        }
        
        return result;
    }
}