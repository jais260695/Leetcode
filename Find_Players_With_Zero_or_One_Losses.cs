public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {  
        List<List<int>> result = new List<List<int>>();
        int n = matches.Count();
        int[] inDegree = new int[100001];
        int[] outDegree = new int[100001];

        for(int i=0;i<n;i++)
        {
            outDegree[matches[i][0]]++;
            inDegree[matches[i][1]]++;
        }

        List<int> noLost = new List<int>();
        List<int> exactlyOneLost = new List<int>();

        for(int i=0;i<100001;i++)
        {
            if(inDegree[i]==0 && outDegree[i]>0)
            {
                noLost.Add(i);
            }

            if(inDegree[i]==1 )
            {
                exactlyOneLost.Add(i);
            }
        }

        result.Add(noLost);
        result.Add(exactlyOneLost);

        return result.ToList<IList<int>>();
    }
}