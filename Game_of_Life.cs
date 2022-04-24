public class Solution {
    public void GameOfLife(int[][] board) {
        int n = board.Count();
        int m = board[0].Count();
        
        int[] xDir = new int[8]{-1,-1,-1,0,0,1,1,1};
        int[] yDir = new int[8]{-1,0,1,-1,1,-1,0,1};
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                int neighbours = 0;
                for(int d = 0;d<8;d++)
                {
                    int x = i+xDir[d];
                    int y = j+yDir[d];
                    if(x<0 || x>=n || y<0 || y>=m) continue;
                    if(board[x][y]>=1)
                    {
                        neighbours++;
                    }
                }
                
                if(board[i][j]==1)
                {
                    if(neighbours<2)
                    {
                        board[i][j]=2;
                    }
                    else if(neighbours>3)
                    {
                        board[i][j]=2;
                    }
                }
                else if(neighbours==3)
                {
                    board[i][j] = -1;
                }
            }
        }
        
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                
                if(board[i][j]==2)
                {
                    board[i][j]=0;
                }
                else if(board[i][j]==-1)
                {
                    board[i][j] = 1;
                }
            }
        }
        
    }
}