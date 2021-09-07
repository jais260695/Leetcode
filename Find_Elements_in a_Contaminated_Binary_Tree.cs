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
public class FindElements {
    TreeNode p;
    HashSet<int> hashSet = new HashSet<int>();
    public FindElements(TreeNode root) {
        p=root;
        Recover(root,0);
    }    
    public void Recover(TreeNode root,int i)
    {
        root.val = i;
        hashSet.Add(i);
        if(root.left!=null) Recover(root.left,2*i+1);
        if(root.right!=null) Recover(root.right,2*i+2);
    } 
    public bool Find(int target) {
        return hashSet.Contains(target);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */