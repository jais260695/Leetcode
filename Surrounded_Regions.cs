public class Solution {
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    
    public void DFS(char[][] board, int i, int j, int n, int m)
    {
        board[i][j] = 'V';
        for(int d = 0; d < 4; d++)
        {
            int x = i + xDir[d];
            int y = j + yDir[d];
            if(x>=n || x<0 || y>=m || y<0 || board[x][y]!='O') continue;
            DFS(board,x,y,n,m);            
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