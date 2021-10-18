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
    List<int> res = new List<int>();
    public void Merge(List<int> left, List<int> right)
    {
        int n1 = left.Count();
        int n2 = right.Count();
        int i = 0, j=0;
        while(i<n1 && j<n2)
        {
            if(left[i]<=right[j])
            {
                res.Add(left[i]);
                i++;
            }
            else
            {
                res.Add(right[j]);
                j++;
            }
        }
        
        while(i<n1)
        {
            res.Add(left[i]);
            i++;
        }
        
        while(j<n2)
        {
            res.Add(right[j]);
            j++;
        }
    }
    public void InOrder(TreeNode root, List<int> list)
    {
        if(root==null) return;
        
        InOrder(root.left,list);
        list.Add(root.val);
        InOrder(root.right,list);
    }
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        InOrder(root1,left);
        InOrder(root2,right);
        
        Merge(left,right);
        
        return res.ToList<int>();
    }
}