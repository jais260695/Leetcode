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
    HashSet<int> map;
    List<TreeNode> result;
    
    public bool Solve(TreeNode root)
    {
        if(root.left!=null && Solve(root.left))
        {
            root.left=null;
        }
        
        if(root.right!=null && Solve(root.right))
        {
            root.right=null;
        }
        
        if(map.Contains(root.val))
        {
            if(root.left!=null)
            {
                result.Add(root.left);
            }
            if(root.right!=null)
            {
                result.Add(root.right);
            }
            return true;
        }
        
        return false;
    }
    
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        int n = to_delete.Count();
        
        result = new List<TreeNode>();
        map = new HashSet<int>();
        
        for(int i=0;i<n;i++)
        {
            map.Add(to_delete[i]);
        }
        
        if(!Solve(root))
        {
            result.Add(root);
        }
        
        return result.ToList<TreeNode>();
    }
}