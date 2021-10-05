public class Solution {
    
    
    public void DFS(char[][] board, int i, int j, int n, int m)
    {
        board[i][j] = 'V';
        if(i+1<n)
        {
            if(board[i+1][j]=='O')
            {
                DFS(board,i+1,j,n,m);
            }
        }
        if(i-1>=0)
        {
            if(board[i-1][j]=='O')
            {
                DFS(board,i-1,j,n,m);
            }
        }
        if(j+1<m)
        {
            if(board[i][j+1]=='O')
            {
                DFS(board,i,j+1,n,m);
            }
        }
        if(j-1>=0)
        {
            if(board[i][j-1]=='O')
            {
                DFS(board,i,j-1,n,m);
            }
        }
    }
    
    public void Solve(char[][] board) {
        int n = board.Count();
        if(n==0) return ;
        int m = board[0].Count();
        
        
            for(int j=0;j<m;j++)
            {
                if(board[0][j]=='O')
                {
                    DFS(board,0,j,n,m);
                }
            }
        for(int j=0;j<m;j++)
            {
                if(board[n-1][j]=='O')
                {
                    DFS(board,n-1,j,n,m);
                }
            }
        for(int i=0;i<n;i++)
            {
                if(board[i][0]=='O')
                {
                    DFS(board,i,0,n,m);
                }
            }
        for(int i=0;i<n;i++)
            {
                if(board[i][m-1]=='O')
                {
                    DFS(board,i,m-1,n,m);
                }
            }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(board[i][j]=='V')
                {
                    board[i][j]='O';
                }
                else
                {
                    board[i][j]='X';
                }
            }
        }
        
    }
}