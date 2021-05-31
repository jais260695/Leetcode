public class Solution {
    int result = 0;
    public bool IsSafe(int[,] list, int R, int C, int n)
    {
        int r = R - 1;
        int c = C - 1;
        while( c >= 0 && r >= 0 )
        {
            if(list[r,c]==1)
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
            if(list[r,c]==1)
            {
                return false;
            }
            c--;
            r++;
        }
        
        c = C-1;
        while( c >= 0 )
        {
            if(list[R,c]==1)
            {
                return false;
            }
            c--;
        }
        
        return true;
    }
    
    public void NQueen(int[,] list,int n, int c)
    {
        if(c>=n) 
        {
            result++;
            return;
        }
        for(int i=0;i<n;i++)
        {
            list[i,c] = 1;
            if(IsSafe(list,i,c,n))
            {
                
                NQueen(list,n,c+1);
            }
            list[i,c] = 0;
        }
        return;
    }
    public int TotalNQueens(int n) {
        int[,] list = new int[n,n];
       
        NQueen(list,n,0);
          
        return result;
    }
}