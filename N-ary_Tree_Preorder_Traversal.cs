/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    List<int> res = new List<int>();
    public void PreOrder(Node root)
    {
        if(root==null) return;
        res.Add(root.val);
        foreach(var node in root.children)
        {
            PreOrder(node);
        }
    }
    public IList<int> Preorder(Node root) {
        PreOrder(root);
        return res.ToList<int>();
    }
}