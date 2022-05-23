public class TopVotedCandidate {

    Dictionary<int,List<int>> dict  = new Dictionary<int, List<int>>();
    public TopVotedCandidate(int[] persons, int[] times) {
        int n = persons.Count();
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(persons[i]))
            {
                dict.Add(persons[i], new List<int>());
            }
            
            dict[persons[i]].Add(times[i]);
        }
    }
    
    public int BinarySearch(List<int> list, int val)
    {
        int l = 0;
        int r = list.Count()-1;
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            
            if(list[mid]<=val)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        
        return r+1;
    }
    
    public int Q(int t) {
        int winner = -1;
        int maxVotes = -1;
        foreach(KeyValuePair<int,List<int>> kvp in dict)
        {
            int votes = BinarySearch(kvp.Value,t);
            
            if(votes>maxVotes)
            {
                maxVotes = votes;
                winner = kvp.Key;
            }
            else if(votes==maxVotes && votes!=0 && dict[winner][maxVotes-1] <= dict[kvp.Key][maxVotes-1] )
            {
                winner = kvp.Key;
            }
        }
        
        return winner;
    }
}

/**
 * Your TopVotedCandidate object will be instantiated and called as such:
 * TopVotedCandidate obj = new TopVotedCandidate(persons, times);
 * int param_1 = obj.Q(t);
 */