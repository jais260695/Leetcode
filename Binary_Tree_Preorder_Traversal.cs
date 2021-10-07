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
    public IList<int> PreorderTraversal(TreeNode root) {
        
        List<int> result = new List<int>();
        if(root==null) return result;
        
        Stack<TreeNode> st = new Stack<TreeNode>();
        
        st.Push(root);
        
        while(st.Count()>0)
        {
            TreeNode n = st.Pop();
            result.Add(n.val);
            Console.Write(n.val+" ");
            
            if(n.right!=null)
            {
                st.Push(n.right);
            }
            if(n.left!=null)
            {
                st.Push(n.left);
            }
            
        }
        return result;
        
    }
}