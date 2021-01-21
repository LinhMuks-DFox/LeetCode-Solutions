using System;
using System.Collections.Generic;
// Link: https://leetcode-cn.com/problems/binary-tree-postorder-traversal/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
     }
}
public class Solution{
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> ret = new List<int>(10);
        PostorderTraversal(root, ret);
        return ret;
    }

    public void PostorderTraversal(TreeNode node, IList<int> list){
        if(node == null)
            return;
        PostorderTraversal(node.left, list);
        PostorderTraversal(node.right, list);
        list.Add(node.val);
    }
}
