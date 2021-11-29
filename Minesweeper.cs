public class Solution {
    public char[][] UpdateBoard(char[][] board, int[] click) {
        int n = board.Count();
        int m = board[0].Count();
        
        if(board[click[0]][click[1]]=='M')
        {
            board[click[0]][click[1]] = 'X';
            return board;
        }
        
        int[,] directions = new int[8,2]{{0,1}, {0,-1}, {1,0}, {-1,0}, {-1,-1}, {1,1}, {1,-1}, {-1,1}};
        
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        queue.Enqueue(new Tuple<int,int>(click[0],click[1]));
        board[click[0]][click[1]] = 'B';
        while(queue.Count()>0)
        {
            Tuple<int,int> coordinates = queue.Dequeue();
            int x = coordinates.Item1;
            int y = coordinates.Item2;
            int countAdjMines = 0,u,v;
            List<Tuple<int,int>> adjList = new List<Tuple<int,int>>();
            for(int dir=0;dir<8;dir++)
            {
                u = x + directions[dir,0];
                v = y + directions[dir,1];
                if(u>=0 && u<n && v>=0 && v<m && (board[u][v]=='M' || board[u][v]=='E'))
                {
                    if(board[u][v]=='M')
                    {
                        countAdjMines++;
                    }
                    if(countAdjMines==0)
                        adjList.Add(new Tuple<int,int>(u,v));
                }
            }
            
            if(countAdjMines==0)
            {      
                foreach(var adj in adjList)
                {
                    board[adj.Item1][adj.Item2] = 'B';
                    queue.Enqueue(adj);
                }
            }   
            else
            {
                board[x][y] = (char)(countAdjMines + '0');
            }
            adjList.Clear();
        }
        return board;
    }
}