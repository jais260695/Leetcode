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
    int leftOfX = 0;
    int rightOfX = 0;
    int countOfX = 0;
    public int CountNodesAtX(TreeNode root,int x)
    {
        if(root==null) return 0;

        int countLeft = CountNodesAtX(root.left,x);
        int countRight = CountNodesAtX(root.right,x);
        if(root.val==x)
        {
            leftOfX = countLeft;
            rightOfX = countRight;
            countOfX = 1 + countLeft + countRight;
        }
        return  1 + countLeft + countRight;
    }
    public bool BtreeGameWinningMove(TreeNode root, int n, int x) {
        CountNodesAtX(root,x);
        return (n-countOfX) > countOfX || (n-leftOfX) < leftOfX || (n-rightOfX) < rightOfX;
    }
}