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
    public class Pair
    {
        public TreeNode node;
        public int v;
        public Pair(TreeNode n, int V)
        {
            node = n;
            v = V;
        }
        
    }
    public IList<int> PostorderTraversal(TreeNode root) {
            Stack<Pair> st=new Stack<Pair>();
            List<int> result = new List<int>();
        if(root==null) return result;
          st.Push(new Pair(root,0));
        
        while(st.Count()>0)
        {
            Pair temp = st.Pop();
            
            if(temp.node==null)
            {
                continue;
            }
            
            if(temp.v==0)
            {
                st.Push(new Pair(temp.node,1));
                st.Push(new Pair(temp.node.left,0));
            }
            else if(temp.v==1)
            {
                st.Push(new Pair(temp.node,2));
                st.Push(new Pair(temp.node.right,0));
            }
            else
            {
                result.Add(temp.node.val);
            }
        }
        return result;
    }
    
}