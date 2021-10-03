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
    HashSet<int> map = new HashSet<int>();
    public void DFS(TreeNode root)
    {
        if(root==null) return;
        map.Add(root.val);
        DFS(root.left);
        DFS(root.right);
    }
    
    public bool FindTarget(TreeNode root, int k) {
        DFS(root);
        foreach(int key in map)
        {
            if(k-key!=key && map.Contains(k-key)) return true;
        }
        return false;
    }
}