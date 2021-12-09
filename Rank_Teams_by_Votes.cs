public class Solution {
    
    public string RankTeams(string[] votes) {
        int n = votes.Count();
        if(n==1) return votes[0];   
        
        int m = votes[0].Length;
        
        Dictionary<char,int[]> teamRankings = new Dictionary<char,int[]>();
        char[] result = new char[m];
        for(int i=0;i<m;i++)
        {
            teamRankings.Add(votes[0][i],new int[m]);
            result[i] = votes[0][i];
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                teamRankings[votes[i][j]][j]++;
            }
        }
        
        Array.Sort
        (
            result, 
            (char c1, char c2) => 
            {
                           for(int i=0;i<m;i++)
                           {
                               if(teamRankings[c1][i] !=  teamRankings[c2][i])
                                   return teamRankings[c2][i] - teamRankings[c1][i];
                           }
                           return c1 - c2;
            }
        );
        
        
        
        return new string(result);
    }
}