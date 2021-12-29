using System;
using System.Collections.Generic;
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<int> ret = new List<int>();
        while(q.Count != 0){
            TreeNode cur = q.Dequeue();
            ret.Add(cur.val);

            if(cur.left != null) q.Enqueue(cur.left);
            if(cur.right != null) q.Enqueue(cur.right);
        }

        return ret;
    }
}
