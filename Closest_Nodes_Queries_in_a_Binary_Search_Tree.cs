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
    List<int> inOrder = new List<int>();
    void InOrder(TreeNode root)
    {
        if(root==null) return;
        InOrder(root.left);
        inOrder.Add(root.val);
        InOrder(root.right);
    }
    
    public int JustGreaterOrEqual(int key)
    {
        int l = 0;
        int r = inOrder.Count()-1;
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(inOrder[mid]<key)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return l==inOrder.Count() ? -1 : inOrder[l];
    }
    
    public int JustSmallerOrEqual(int key)
    {
        int l = 0;
        int r = inOrder.Count()-1;
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(inOrder[mid]>key)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return r==-1 ? -1 : inOrder[r];
    }
    public IList<IList<int>> ClosestNodes(TreeNode root, IList<int> queries) {
        InOrder(root);
        
        List<List<int>> result = new List<List<int>>();
        
        foreach(int q in queries)
        {
            int small = JustSmallerOrEqual(q);
            int large = JustGreaterOrEqual(q);
        
            result.Add(new List<int>(){small,large});
        }
        
        return result.ToList<IList<int>>();
    }
}