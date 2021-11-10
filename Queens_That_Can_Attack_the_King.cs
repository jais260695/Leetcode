public class Solution {
    public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king) {
        int[,] cb = new int[8,8];
        
        int qSize = queens.Count();
        for(int i=0;i<qSize;i++)
        {
            cb[queens[i][0],queens[i][1]] = 1;
        }
        List<List<int>> res = new List<List<int>>();
        int r = king[0];
        int c = king[1];
        for(int i = r-1;i>=0;i--)
        {
            if(cb[i,c]==1)
            {
                res.Add(new List<int>{i,c});
                break;
            }
        }
        
        for(int i = r+1;i<8;i++)
        {
            if(cb[i,c]==1)
            {
                res.Add(new List<int>{i,c});
                break;
            }
        }
        
        for(int i = c+1;i<8;i++)
        {
            if(cb[r,i]==1)
            {
                res.Add(new List<int>{r,i});
                break;
            }
        }
        
        for(int i = c-1;i>=0;i--)
        {
            if(cb[r,i]==1)
            {
                res.Add(new List<int>{r,i});
                break;
            }
        }
        
        for(int i = r-1,j=c-1;i>=0 && j>=0;i--,j--)
        {
            if(cb[i,j]==1)
            {
                res.Add(new List<int>{i,j});
                break;
            }
        }
        
        for(int i = r+1,j=c+1;i<8 && j<8;i++,j++)
        {
            if(cb[i,j]==1)
            {
                res.Add(new List<int>{i,j});
                break;
            }
        }
        
        for(int i = r-1,j=c+1;i>=0 && j<8;i--,j++)
        {
            if(cb[i,j]==1)
            {
                res.Add(new List<int>{i,j});
                break;
            }
        }
        
        for(int i = r+1,j=c-1;i<8 && j>=0;i++,j--)
        {
            if(cb[i,j]==1)
            {
                res.Add(new List<int>{i,j});
                break;
            }
        }
        
        return res.ToList<IList<int>>();
    }
}