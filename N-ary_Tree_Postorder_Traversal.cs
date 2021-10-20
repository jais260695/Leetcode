/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    List<int> res = new List<int>();
    public void PostOrder(Node root)
    {
        if(root==null) return;
        foreach(var node in root.children)
        {
            PostOrder(node);
        }
        
        res.Add(root.val);
    }
    public IList<int> Postorder(Node root) {
        PostOrder(root);
        return res.ToList<int>();
    }
}