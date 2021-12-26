public class Solution {
    
    public bool IsSafe(char[][] board, char ch, int x, int y)
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
        for(int i=0;i<9;i++)
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
    
    public bool Solve(char[][] board)
    {
        int r = -1;
        int c = -1;
        for(int i=0;i<9;i++)
        {
            for(int j =0 ;j<9;j++)
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
        for(int i=1;i<=9;i++)
        {
                char ch = (char)(48+i);
                if(IsSafe(board,ch,r,c))
                {
                    board[r][c] = ch;
                    if(Solve(board))
                        return true;
                    board[r][c] = '.';
                }
        }
        return false;
    }
    
    public void SolveSudoku(char[][] board) {
        Solve(board);
    }
}