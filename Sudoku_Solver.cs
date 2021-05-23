public class Solution {
    
    public bool IsSafe(char[][] board, char ch, int x, int y, int n)
    {
        int a = (x/3)*3;
        int b = (y/3)*3;
        for(int i=a;i<a+3;i++)
        {
            for(int j=b;j<b+3;j++)
            {
                if(i!=x && j!=y && (board[i][j] == ch))
                {
                    return false;
                }
            }
        }
        for(int i=0;i<n;i++)
        {
            if(i!=y && board[x][i]==ch)
            {
                return false;
            }
            if(i!=x && board[i][y]==ch)
            {
                return false;
            }
        }
        return true;
    }   
    
    public bool DFS(char[][] board, int n)
    {
        int r = -1;
        int c = -1;
        for(int i=0;i<n;i++)
        {
            for(int j =0 ;j<n;j++)
            {
                if(board[i][j]=='.')
                {
                    if(r==-1 && c==-1)
                    {
                        r = i;
                        c = j;
                        break;
                    }
                }
            }
            if(r!=-1 && c!=-1)
            {
                        break;
            }
        }
        if(r==-1 && c == -1)
        {
            return true;
        }
        for(int i=0;i<n;i++)
        {
                char ch = (char)(49+i);
                if(IsSafe(board,ch,r,c,n))
                {
                    board[r][c] = ch;
                    if(DFS(board,n) )
                        return true;
                    board[r][c] = '.';
                }
        }
        return false;
    }
    
    public void SolveSudoku(char[][] board) {
        int n = board.Count();
        DFS(board,n);
    }
}