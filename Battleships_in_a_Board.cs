public class Solution {
    public int CountBattleships(char[][] board) {
        int ans = 0;
        int n = board.Count();
        int m = board[0].Count();
        for(int j=0;j<m;j++)
        {
            for(int i=0;i<n;i++)
            {
                if(board[i][j]=='X')
                {
                    if((i-1<0 || board[i-1][j]!='X') && (j-1<0 || board[i][j-1]!='X'))
                    {
                        ans++;
                    }
                }
            }
        }
        return ans;
    }
}