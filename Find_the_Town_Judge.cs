public class Solution {
    public class Pair
    {
        public int inDegree;
        public int outDegree;
        public Pair(int i=0, int o=0)
        {
            inDegree =i;
            outDegree = o;
        }
        
    }
    public int FindJudge(int N, int[][] trust) {
        List<Pair> result = new List<Pair>();
        
        for(int i=0;i<N;i++)
        {
            result.Add(new Pair());
        }
        
        for(int i=0;i<trust.Count();i++)
        {
            result[trust[i][0]-1].outDegree++;
            result[trust[i][1]-1].inDegree++;
        }
        
        int res = result.FindIndex(i=> i.inDegree==N-1 && i.outDegree==0);
   
        return res==-1?res:res+1;
       
        
    }
}