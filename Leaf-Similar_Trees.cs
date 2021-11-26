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
    public void DFS(TreeNode t, List<int> list)
    {
        if(t==null) return;
        if(t.left==null && t.right==null)
        {
            list.Add(t.val);
            
        }
        DFS(t.left,list);
        DFS(t.right,list);
    }
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> res1 = new List<int>();
        DFS(root1,res1);
        List<int> res2 = new List<int>();
        DFS(root2,res2);
        if(res1.SequenceEqual(res2))
        {
            return true;
        }
        return false;
    }
}