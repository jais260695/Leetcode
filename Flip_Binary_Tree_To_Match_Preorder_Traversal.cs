
public class Solution {
    List<int> result  = new List<int>();
    public int i=0;
    public bool PreOrder(TreeNode root, int[] voyage)
    {
        if(root==null) return true;
        if(root.val != voyage[i]) return false;
        i++;
        if(root.left!=null && voyage[i]!=root.left.val)
        {
            if(root.right!=null && voyage[i]!=root.right.val) return false;            
            result.Add(root.val); 
            return PreOrder(root.right,voyage) && PreOrder(root.left,voyage);
        }

        return PreOrder(root.left,voyage) && PreOrder(root.right,voyage);
    }
    
    public void SwapNodes(TreeNode root)
    {
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
    }
    
    public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage) {
        
        if(PreOrder(root,voyage))
        {
            return result.ToList<int>();
        }
        result.Clear();
        result.Add(-1);
        return result.ToList<int>();
    }
}