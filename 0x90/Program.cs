using System;
using System.Collections.Generic;
/*
    Link: https://leetcode-cn.com/problems/binary-tree-preorder-traversal/
*/
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
class Solution
{
    public IList<int> PreorderTraversal(TreeNode root) 
    {
        List<int> ret = new List<int>(10);
        PreorderTraversal(root, ret);
        return ret;
    }

    public void PreorderTraversal(TreeNode node, List<int> list)
    {
        if(node == null)
            return;
        list.Add(node.val);
        PreorderTraversal(node.left, list);
        PreorderTraversal(node.right, list);
    }
}


