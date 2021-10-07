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
    public IList<int> InorderTraversal(TreeNode root) {
        Stack<TreeNode>  st = new Stack<TreeNode>();
        List<int> result = new List<int>();
        if(root==null) return result;
        st.Push(root);
        TreeNode temp = st.Peek();
            while(temp.left!=null)
            {
                temp=temp.left;
                st.Push(temp);
            }
        
        while(st.Count()>0)
        {
           
            temp  = st.Pop();
            result.Add(temp.val);
            if(temp.right!=null)
            {
                temp = temp.right;
                st.Push(temp);
                while(temp.left!=null)
                {
                    temp=temp.left;
                    st.Push(temp);
                }
            }
            
            
        }
        return result;
        
    }
}