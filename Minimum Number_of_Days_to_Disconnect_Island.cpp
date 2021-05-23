class Solution {
    
public:
    int disc[10001], low[10001], parent[10001];
    int flag=2, t=0;
    int apdfs(vector<vector<int>> &adj, vector<int> &vis, int src){
        t++;
        int node=0;
        disc[src]=low[src]=t;
        for(int i:adj[src]){
            if(vis[i]==0){
                vis[i]=1;
                parent[i]=src;
                node++;
                apdfs(adj, vis, i);
                low[src]=min(low[src], low[i]);
                if(node>1 && parent[src]==0)flag= 1;
                if(parent[src]!=0){
                    if(disc[src]<=low[i]){flag= 1;}
                }
            }
            else if(parent[src]!=i){
                low[src]=min(disc[i], low[src]);
            }
        }
        return 0;
    }
    
    
    
    
    int minDays(vector<vector<int>>& grid) {
        int n=grid.size();
        int m=grid[0].size();
        
        vector<vector<int>> adj(m*n+1);
        vector<int> vis(n*m+1, 0);
        
        if(n*m==1 && grid[0][0]==1)return 1;
        if(n*m==1 && grid[0][0]==0)return 0;
        
        int x=0;
        int t = 0;
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                x++;
                if(grid[i][j]==0){continue;}
                t++;
                grid[i][j]=x; 
            }
        }
        
        if(t==1) return 1;
        
         for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                if(grid[i][j]!=0){
                    if(i+1<n && grid[i+1][j]!=0 ){
                        adj[grid[i][j]].push_back(grid[i+1][j]);}
                    if(j+1<m && grid[i][j+1]!=0){
                        adj[grid[i][j]].push_back(grid[i][j+1]);}
                    if(i>0 && grid[i-1][j]!=0){
                        adj[grid[i][j]].push_back(grid[i-1][j]);}
                    if(j>0 && grid[i][j-1]!=0){
                        adj[grid[i][j]].push_back(grid[i][j-1]);}

                    if(adj[grid[i][j]].size()==0){return 0;}
                }
            }
        }
        
        for(int i=0; i<=m*n; i++){
            disc[i]=0; low[i]=0; parent[i]=0;
        }
        
        int c=0;
        for(int i=1; i<=m*n; i++){
            if(vis[i]==0 && adj[i].size()!=0){
                vis[i]=1;
                c++;
                apdfs(adj,vis, i);
            }
        }
        
        if(c==1)return flag;
        return 0;
        
        
        
    }
};