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
    
    public class Pair
    {
        public TreeNode node;
        public int index;
        public Pair(TreeNode n, int i)
        {
            node = n;
            index = i;
        }
    }
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root==null) return "";
        Queue<TreeNode> queue = new Queue<TreeNode>();
        string result = "";
        queue.Enqueue(root);
        result+=root.val;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();      
                if(temp.left!=null)
                {
                    queue.Enqueue(temp.left);
                    result+=(","+temp.left.val);
                }
                else
                {
                    result+=(","+null);
                }
                
                if(temp.right!=null)
                {
                    queue.Enqueue(temp.right);
                    result+=(","+temp.right.val);
                }
                else
                {
                    result+=(","+null);
                }                
                size--;
            }
        }
        return result;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(String.IsNullOrEmpty(data)) return null;
        string[] encodedBST = data.Split(',');
        int n = encodedBST.Count();
        TreeNode root = new TreeNode(Convert.ToInt32(encodedBST[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            { 
                TreeNode temp = queue.Dequeue();
                int left = ++i;
                int right = ++i;
                if(left<n && !String.IsNullOrEmpty(encodedBST[left]))
                {
                    temp.left = new TreeNode(Convert.ToInt32(encodedBST[left]));
                    queue.Enqueue(temp.left);
                }
                if(right<n && !String.IsNullOrEmpty(encodedBST[right]))
                {
                    temp.right = new TreeNode(Convert.ToInt32(encodedBST[right]));
                    queue.Enqueue(temp.right);
                }
                size--;
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));