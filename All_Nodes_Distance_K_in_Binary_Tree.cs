/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        List<int>[] adjList = new List<int>[501];
        
        for(int i=0;i<=500;i++)
        {
            adjList[i] = new List<int>();
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count()>0)
        {
            TreeNode t = queue.Dequeue();
            
            int u = t.val;
            
            if(t.left!=null)
            {
                int v = t.left.val;
                
                adjList[u].Add(v);
                adjList[v].Add(u);
                
                queue.Enqueue(t.left);
            }
            
            if(t.right!=null)
            {
                int v = t.right.val;
                
                adjList[u].Add(v);
                adjList[v].Add(u);
                
                queue.Enqueue(t.right);
            }
        }
        
        
        bool[] visited = new bool[501];
        List<int> result = new List<int>();
        
        Queue<int> q = new Queue<int>();       
        q.Enqueue(target.val);
        
        visited[target.val] = true;
        
        int level = 0;
        
        while(q.Count()>0)
        {
            
            if(level==k) break;
            
            int size = q.Count();
            
            while(size>0)
            {
                int u = q.Dequeue();
                
                foreach(int v in adjList[u])
                {
                    if(!visited[v])
                    {
                        visited[v] = true;
                        
                        q.Enqueue(v);
                    }
                }
                
                size--;
            }
            
            level++;
            
        }
        
        while(q.Count()>0)
        {
            result.Add(q.Dequeue());
        }       
        
        return result.ToList<int>();
    }
}