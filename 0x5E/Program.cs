using System;
using System.Collections.Generic;
/*
    Link: https://leetcode-cn.com/problems/binary-tree-inorder-traversal/
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

public class Solution{

    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ret = new List<ret>(10);
        InorderTraversal(root, ret);
        return ret;
    }

    public void InorderTraversal(TreeNode node, IList<int> list){
        if(node == null)
            return;
        InorderTraversal(node.left, list);
        lsit.Add(node.val);
        InorderTraversal(node.right, list);
    }
}