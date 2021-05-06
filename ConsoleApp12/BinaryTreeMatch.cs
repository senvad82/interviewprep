using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class BinaryTreeMatch
    {

        //Naive Solution O(m*n)
        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            int count = 0;
            var node = findNode(root, subRoot, count);
            if (node == null) return false;
            Console.WriteLine(node.val);
            return isIdentical(node, subRoot);

        }

        public static TreeNode findNode(TreeNode root, TreeNode subroot, int count)
        {
            if (root == null || subroot == null) return null;
            if (count > 0 && root.val == subroot.val) return root;
            Console.WriteLine(root.val);
            count++;
            return findNode(root.left, subroot, count);
            return findNode(root.right, subroot, count);
            return null;
        }

        public static bool isIdentical(TreeNode root, TreeNode subroot)
        {
            if (root == null && subroot == null) return true;
            if (root == null || subroot == null) return false;
            if (root.val != subroot.val) return false;
            if (!isIdentical(root.left, subroot.left)) return false;
            if (!isIdentical(root.right, subroot.right)) return false;
            return true;

        }

        //Efficei

        public static bool IsSubtree2(TreeNode root, TreeNode subRoot)
        {
            return Traverse(root, subRoot);

        }
        public static bool equals(TreeNode root, TreeNode subroot)
        {
            if (root == null && subroot == null) return true;
            if (root == null || subroot == null) return false;
            var currentVal = (root.val == subroot.val) ? true : false;
            var leftVal = equals(root.left, subroot.left);
            var rightVal = equals(root.right, subroot.right);

            return (currentVal && leftVal && rightVal);
        }
        public static bool Traverse(TreeNode root, TreeNode subroot)
        {

            return (root != null && (equals(root, subroot) || Traverse(root.left, subroot) || Traverse(root.right, subroot)));
        }



    }
}
