public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        HashSet<int> winners = new HashSet<int>();
        Dictionary<int,int> losers = new Dictionary<int,int>();
        
        for(int i=0;i<matches.Count();i++)
        {
            if(!losers.ContainsKey(matches[i][1]))
            {
                losers.Add(matches[i][1],0);
            }
            
            winners.Add(matches[i][0]);
            losers[matches[i][1]]++;
        }
        
        List<List<int>> result = new List<List<int>>();
        List<int> tempResult = new List<int>();
        
        foreach(var player  in winners)
        {
            if(!losers.ContainsKey(player))
            {
                tempResult.Add(player);
            }
        }
        
        tempResult.Sort();
        result.Add(new List<int>(tempResult));
        
        tempResult.Clear();
        
        foreach(KeyValuePair<int,int> kvp  in losers)
        {
            int player = kvp.Key;
            if(kvp.Value==1)
            {
                tempResult.Add(player);
            }
        }
        
        tempResult.Sort();
        result.Add(new List<int>(tempResult));
        
        tempResult.Clear();
        winners.Clear();
        losers.Clear();
        
        return result.ToList<IList<int>>();
    }
}