public class Solution {
   
    
    public void DFS(IList<IList<int>> rooms,int u,bool[] visited)
    {
        visited[u]=true;
        for(int i = 0;i<rooms[u].Count();i++)
        {
            if(!visited[rooms[u][i]])
            {
                DFS(rooms,rooms[u][i],visited);
            }
        }
    }
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        int N = rooms.Count();
        
        bool[] visited = new bool[N];
         int c=0;
        for(int i=0;i<N;i++)
        {
            if(!visited[i])
            {
                c++;
                DFS(rooms,i,visited);
            }
            if(c>1) return false;
        }
        return true;
    }
}