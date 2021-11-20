public class Solution {
    public int NumRookCaptures(char[][] board) {
        int n = board.Count();
        int m = board[0].Count();
        int x = -1;
        int y = -1;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(board[i][j] == 'R')
                {
                    x = i;
                    y = j;
                    break;
                }
            }
            if(x!=-1) break;
        }
        int res = 0;
        for(int i=x+1;i<n;i++)
        {
            if(board[i][y] == 'B') break;
            if(board[i][y] == 'p') {res++; break;}
        }
        
        for(int i=x-1;i>=0;i--)
        {
            if(board[i][y] == 'B') break;
            if(board[i][y] == 'p') {res++; break;}
        }
        
        for(int i=y+1;i<m;i++)
        {
            if(board[x][i] == 'B') break;
            if(board[x][i] == 'p') {res++;break;}
        }
        
        for(int i=y-1;i>=0;i--)
        {
            if(board[x][i] == 'B') break;
            if(board[x][i] == 'p') {res++;break;}
        }
        
        return res;
    }
}