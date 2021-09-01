public class Solution {
    public string ConvertToString(int[][] board)
    {
        string str = "";
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                str += board[i][j];
            }
        }
        return str;
    }
    public Tuple<int, int> FindZero(int[][] board)
    {
        int i = 0, j = 0;
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 3; j++)
            {
                if (board[i][j] == 0)
                {
                    Tuple<int, int> t1 = new Tuple<int, int>(i, j);
                    return t1;
                }
            }
        }
        Tuple<int, int> t = new Tuple<int, int>(i, j);
        return t;
    }
    public void Swap(int[][] board, int i, int j, int x, int y)
    {
        int temp = board[i][j];
        board[i][j] = board[x][y];
        board[x][y] = temp;
    }

    public int[][] CreateBoard(int[][] board)
    {
        int[][] iBoard = new int[2][];
        for (int i = 0; i < 2; i++)
        {
            iBoard[i] = new int[3];
            for (int j = 0; j < 3; j++)
            {
                iBoard[i][j] = board[i][j];
            }
        }
        return iBoard;
    }
    public int SlidingPuzzle(int[][] board)
    {
        string target = "123450";

        HashSet<string> visited = new HashSet<string>();
        visited.Add(ConvertToString(board));

        Queue<int[][]> queue = new Queue<int[][]>();
        queue.Enqueue(board);

        int[] xCoord = new int[4] { 0, 0, 1, -1 };
        int[] yCoord = new int[4] { 1, -1, 0, 0 };

        int level = 0;

        while (queue.Count() > 0)
        {
            int size = queue.Count();
            while (size > 0)
            {
                int[][] interBoard = queue.Dequeue();
                Tuple<int, int> zeroCoord = FindZero(interBoard);
                string toString = ConvertToString(interBoard);
                if (toString == target) return level;

                int i = zeroCoord.Item1;
                int j = zeroCoord.Item2;

                for (int c = 0; c < 4; c++)
                {
                    int x = i + xCoord[c];
                    int y = j + yCoord[c];

                    if (x < 0 || x >= 2 || y < 0 || y >= 3) continue;

                    Swap(interBoard,i,j,x,y);

                    toString = ConvertToString(interBoard);
                    if (!visited.Contains(toString))
                    {
                        visited.Add(toString);
                        queue.Enqueue(CreateBoard(interBoard));
                    }

                    Swap(interBoard, i, j, x, y);
                }
                size--;
            }
            level++;
        }
        return -1;
    }
}