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
public class BSTIterator {
    Stack<TreeNode> st = new Stack<TreeNode>();
    public void PushInStack(TreeNode root)
    {
        while(root!=null)
        {
            st.Push(root);
            root = root.left;
        }
    }
    public BSTIterator(TreeNode root) {
        PushInStack(root);
    }
    
    public int Next() {
        TreeNode temp = st.Pop();
        int result = temp.val;
        PushInStack(temp.right);
        return result;
    }
    
    public bool HasNext() {
        return st.Count()>0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */