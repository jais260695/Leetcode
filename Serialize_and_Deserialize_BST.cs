/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root==null) return "N-";
        StringBuilder sb = new StringBuilder();
        sb.Append(root.val);
        sb.Append("-");
        sb.Append(serialize(root.left));
        sb.Append(serialize(root.right));
        return sb.ToString();
    }
    
    public TreeNode Solve(Queue<string> queue)
    {
        if(queue.Count()==0)
        {
            return null;
        }
        
        string val = queue.Dequeue();
        
        if(val=="N") return null;
        
        TreeNode root = new TreeNode(Int32.Parse(val));
        
        root.left = Solve(queue);
        root.right = Solve(queue);
        
        return root;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string s) {
        if(string.IsNullOrWhiteSpace(s) || s[0]=='N') return null;       
        string[] data = s.Split("-");       
        int n = data.Count();
        
        
        Queue<string> queue = new Queue<string>();
        
        for(int i=0;i<n;i++)
        {
            queue.Enqueue(data[i]);
        }
        
        return Solve(queue);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;