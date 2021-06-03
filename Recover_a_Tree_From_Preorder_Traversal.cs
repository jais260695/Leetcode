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
    public int nodes = 0;
    public class pair
    {
        public int val;
        public int hgt;
        public pair(int v, int h)
        {
            val = v;
            hgt = h;
        }
    }
    
    public TreeNode DFS( List<pair> arr, int n)
    {
        int u = nodes;
        TreeNode root = new TreeNode();
        root.val = arr[u].val;
        if(nodes+1<n && arr[nodes+1].hgt==arr[u].hgt+1)
        {
            nodes++;
            root.left = DFS(arr,n);
        }
        if(nodes+1<n && arr[nodes+1].hgt==arr[u].hgt+1)
        {
            nodes++;
            root.right = DFS(arr,n);
        }
        return root;
    }
    
    public TreeNode RecoverFromPreorder(string S) {
        int h = 0;
        int n = S.Length;
        string str = "";
        List<pair> p = new List<pair>();
        int i=0;
        while(i<n)
        {
            str="";
            while(i<n && S[i]!='-')
            {
                str+=S[i];
                i++;
            }
            p.Add(new pair( Convert.ToInt32(str.ToString()), h ));
            h = 0;
            while(i<n && S[i]=='-')
            {
                h++;
                i++;
            }
            
        }
        
        return DFS(p,p.Count());
    
    }
}