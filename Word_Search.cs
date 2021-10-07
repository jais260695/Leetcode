public class Solution {
    
    public bool DFS(int u , int v, char[][] board, string word, int n, int m)
    {
        if(word.Length==0) return true;
        if(u+1<n && board[u+1][v]!='0' && board[u+1][v]==word[0])
        {
            board[u+1][v] = '0';   
            if(DFS(u+1,v,board,word.Substring(1),n,m))
            {
                return true;
            }
            board[u+1][v] = word[0];
        }
        
        if(u-1>=0 && board[u-1][v]!='0' && board[u-1][v]==word[0])
        {
            board[u-1][v] = '0';
            if(DFS(u-1,v,board,word.Substring(1),n,m))
            {
                return true;
            }
            board[u-1][v] = word[0];
        }
        
        if(v+1<m && board[u][v+1]!='0' && board[u][v+1]==word[0])
        {
            board[u][v+1]='0';
            if(DFS(u,v+1,board,word.Substring(1),n,m))
            {
                return true;
            }
            board[u][v+1] = word[0];
        }
        
        if(v-1>=0 && board[u][v-1]!='0' && board[u][v-1]==word[0])
        {
            board[u][v-1]='0';
            if(DFS(u,v-1,board,word.Substring(1),n,m))
            {
                return true;
            }
            board[u][v-1] = word[0];
        }
        
        return false;
    }
    public bool Exist(char[][] board, string word) {
        int n = board.Count();
        int m = board[0].Count();
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(board[i][j]==word[0])
                {
                    board[i][j] = '0';
                    if(DFS(i,j,board,word.Substring(1), n, m))
                        return true;
                    board[i][j] = word[0];
                }
            }
        }
        
        return false;
    }
}