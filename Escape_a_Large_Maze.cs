public class Solution {
    HashSet<string> blockedCoordinates;
    int n = 1000000;    
    int[] xDir = new int[4]{0,0,1,-1};
    int[] yDir = new int[4]{1,-1,0,0};
    
    public bool DFS(int u, int v, int sX,int sY, int tX, int tY,HashSet<string> visitedCoordinates)
    {
        //if target is reached return true
        if((u==tX && v ==tY)) return  true;
        
        //if manhatten distance between source and current coordinate is greater than 199 then source is not bounded by blocks and assume target is reachable
        if(Math.Abs(sX-u) + Math.Abs(sY-v) >199) return true;
        
        visitedCoordinates.Add(u+"-"+v);
        
        for(int d=0;d<4;d++)
        {
            int x = u + xDir[d];
            int y = v + yDir[d];
            string temp = x+"-"+y;
            
            if(x<0 || x>=n || y<0 || y>=n || visitedCoordinates.Contains(temp) || blockedCoordinates.Contains(temp)) continue;
            
            if(DFS(x,y,sX,sY,tX,tY,visitedCoordinates))
            {
                return true;
            }
        }
        
        return false;
    }
    
    public bool IsEscapePossible(int[][] blocked, int[] source, int[] target) {
        
        blockedCoordinates = new HashSet<string>();
        
        foreach(int[] block in blocked)
        {
            int x = block[0];
            int y = block[1];
            
            blockedCoordinates.Add(x+"-"+y);
        }
        
        //Search from Source to target assuming that source is bounded by blocks
        //Search from target to source assuming that target is bounded by blocks
        //if both source and target are not bound then return true
        return DFS(source[0],source[1],source[0],source[1], target[0],target[1], new HashSet<string>()) && DFS(target[0],target[1],target[0],target[1], source[0],source[1], new HashSet<string>());
    }
}