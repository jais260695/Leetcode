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
    HashSet<int> result = new HashSet<int>();
    int maxLength = 0;
    int currLength = 0;
    int prev = int.MinValue;
    public void InOrder(TreeNode root)
    {
        if(root==null) return;
        
        InOrder(root.left);
        
        if(root.val==prev)
        {
            currLength++;
        }
        else
        {
            currLength=1;
        }
        
        if(currLength>maxLength)
        {
            result.Clear();
            maxLength = currLength;
            result.Add(root.val);
        }
        else if(currLength==maxLength)
        {
            result.Add(root.val);
        }
        
        prev = root.val;
        
        InOrder(root.right);
        
    }
    public int[] FindMode(TreeNode root) {
        InOrder(root);
        return result.ToArray();
    }
}