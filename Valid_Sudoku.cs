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
    
    public bool IsValidSudoku(char[][] board) 
    {
        int n = board.Count();
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(board[i][j]!='.')
                {
                    if(!IsSafe(board,board[i][j],i,j,n))
                    {
                        return false;
                    }
                }
            }
        }  
        return true;
    }
}