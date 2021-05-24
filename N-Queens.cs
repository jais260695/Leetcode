public class Solution {
    List<List<string>> result = new List<List<string>> ();
    public bool IsSafe(char[,] list, int R, int C, int n)
    {
        int r = R - 1;
        int c = C - 1;
        while( c >= 0 && r >= 0 )
        {
            if(list[r,c]=='Q')
            {
                return false;
            }
            r--;
            c--;
        }
        
        r = R + 1;
        c = C - 1;
        while( c >= 0 && r < n )
        {
            if(list[r,c]=='Q')
            {
                return false;
            }
            c--;
            r++;
        }
        
        c = C-1;
        while( c >= 0 )
        {
            if(list[R,c]=='Q')
            {
                return false;
            }
            c--;
        }
        
        return true;
    }
    
    public void NQueen(char[,] list,int n, int c)
    {
        if(c>=n) 
        {
            List<string> l = new List<string>();
            for(int z = 0;z<n;z++)
            {
                string temp ="";
                for(int x=0;x<n;x++)
                {
                    temp+=list[z,x];
                }
                l.Add(temp);
            }
            result.Add(l);
            return;
        }
        for(int i=0;i<n;i++)
        {
            list[i,c] = 'Q';
            if(IsSafe(list,i,c,n))
            {
                NQueen(list,n,c+1);
            }
            list[i,c] = '.';
        }
        return;
    }
    
    public IList<IList<string>> SolveNQueens(int n) {
       
        char[,] list = new char[n,n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                list[i,j] = '.';
            }
        }
        NQueen(list,n,0);
        return result.ToList<IList<string>>();
    }
}