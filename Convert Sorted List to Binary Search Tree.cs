/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    
    public TreeNode RightRotate(TreeNode root)
    {
        TreeNode newRoot = root.left;
        root.left = newRoot.right;
        newRoot.right = root;
        return newRoot;
    }

    public TreeNode LeftRotate(TreeNode root)
    {
        TreeNode newRoot = root.right;
        root.right = newRoot.left;
        newRoot.left = root;
        return newRoot;
    }

    public int Height(TreeNode root)
    {
        if(root==null) return 0;    
        return Math.Max(Height(root.left),Height(root.right))+1;
    }

    public TreeNode Insert(TreeNode root, int data)
    {
        if(root==null) return new TreeNode(data); 
        if(data<=root.val)
        {
            root.left = Insert(root.left,data);
        }
        else
        {
            root.right = Insert(root.right,data);
        }

        int balanceFactor = Height(root.left) - Height(root.right);
        if(balanceFactor>1)
        {
            if(data>root.left.val)
            {
                root.left = LeftRotate(root);
            }
            return RightRotate(root);
        }
        if(balanceFactor<-1)
        {
            if(data<=root.right.val)
            {
                root.right = RightRotate(root);
            }
            return LeftRotate(root);
        }
        return root;
    }
    
    public TreeNode SortedListToBST(ListNode head) {
        if(head==null) return null;
        TreeNode root = null;
        while(head!=null)
        {
            root = Insert(root,head.val);
            head = head.next;
        }
        return root;
    }
}