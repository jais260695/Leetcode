/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int currentNode = 0;
    int treeSize = 0;
    List<Node> nodes = new List<Node>();
    
    public class Node
    {
        public int val;
        public int hgt;
        public Node(int v, int h)
        {
            val = v;
            hgt = h;
        }
    }    
    
    public TreeNode DFS()
    {
        int u = currentNode;
        TreeNode root = new TreeNode(nodes[u].val);
        
        //if height of next node is 1 + height of current node, add it as left child
        if(currentNode+1 < treeSize && nodes[currentNode+1].hgt == nodes[u].hgt+1)
        {
            currentNode++;
            root.left = DFS();
        }
        
        //if height of next node is 1 + height of current node, add it as right child
        if(currentNode+1 < treeSize && nodes[currentNode+1].hgt == nodes[u].hgt+1)
        {
            currentNode++;
            root.right = DFS();
        }
        return root;
    }
    
    public TreeNode RecoverFromPreorder(string S) {
        int n = S.Length;
        int i = 0;
        
        while(i < n)
        {
            string str = "";
            int h = 0;
            
            //Indentify Height of current Node
            while(i < n && S[i] == '-')
            {
                h++;
                i++;
            }
            
            //Identify current Node
            while(i < n && S[i] != '-')
            {
                str+=S[i];
                i++;
            }
            
            nodes.Add(new Node(Convert.ToInt32(str), h));
        }     
        
        treeSize = nodes.Count();                
        
        return DFS();    
    }
}