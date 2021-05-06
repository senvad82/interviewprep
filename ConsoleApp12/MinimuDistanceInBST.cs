using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }


    }
    public static class MinimuDistanceInBST
    {
        static int minDistance = Int32.MaxValue;
        static TreeNode prev = null;
        public static int getMinimumDIstance(TreeNode root)
        {
            InOrder(root);
            return minDistance;

        }
        public static void InOrder(TreeNode root)
        {

            if (root == null) return;
            InOrder(root.left);
            if (prev != null) minDistance = Math.Min(minDistance, Math.Abs(root.val - prev.val));
            if (prev != null) Console.WriteLine(Math.Abs(root.val - prev.val));
            Console.WriteLine(minDistance);
            prev = root;
            InOrder(root.right);

        }

        public static TreeNode BuildTree(int[] arr)
        {
            TreeNode root = new TreeNode(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                var newNode = new TreeNode(arr[i]);
                root = InsertNode(root, newNode);
            }

            return root;
        }

        public static TreeNode InsertNode(TreeNode root, TreeNode node)
        {
            if (root == null) return node;
            if (root.val < node.val) root.left = InsertNode(root.left, node);
            if (root.val > node.val) root.right = InsertNode(root.right, node);
            return root;
        }
    }
}
