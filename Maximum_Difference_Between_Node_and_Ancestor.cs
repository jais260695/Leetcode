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
    int result = int.MinValue;
    public class Pair
    {
        public int min;
        public int max;
        public Pair(int mi, int ma)
        {
            min = mi;
            max = ma;
        }
    }
    public Pair Solve(TreeNode root)
    {
        if(root.left == null && root.right == null)
        {
           return new Pair(root.val,root.val);
           
        }
        int val = root.val;
        int lMin = int.MaxValue;
        int rMin = int.MaxValue; 
        int lMax = int.MinValue;
        int rMax = int.MinValue;
        
        if(root.left!=null)
        {
            Pair pleft = Solve(root.left);
            int modV = Math.Abs(val - pleft.min);
            if( result<modV)
                result = modV;
            modV = Math.Abs(val - pleft.max);
            if( result<modV)
                result = modV;
            lMin = Math.Min(pleft.min,val);
            lMax = Math.Max(pleft.max,val);
        }
        if(root.right!=null)
        {
            Pair pright = Solve(root.right);
            int modV = Math.Abs(val - pright.min);
            if( result<modV)
                result = modV;
            modV = Math.Abs(val - pright.max);
            if( result<modV)
                result = modV;
            rMin = Math.Min(pright.min,val);
            rMax = Math.Max(pright.max,val);
        }
        
        return new Pair(Math.Min(lMin,rMin), Math.Max(lMax,rMax));
        
    }
        
    public int MaxAncestorDiff(TreeNode root) {
        Solve(root);
        return result;
    }
}