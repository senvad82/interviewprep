using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    // Definition for a Node.
    public class Node {
        public int val;
        public Node next;
        public Node random;
    
        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }
    }


    public static class CopyListWithRandomPointer
    {


        public static Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        public static Node CopyRandomList(Node head)
        {

            Node newHead = null;
            Node prev = null;
            Node originCurrentNode = head;

            while (originCurrentNode != null)
            {
                var newNode = new Node(originCurrentNode.val);
                if (newHead == null)
                {
                    newHead = newNode;
                }
                else if (prev != null)
                {
                    prev.next = newNode;
                }
                prev = newNode;
                map.Add(originCurrentNode, newNode);
                originCurrentNode = originCurrentNode.next;
            }

            originCurrentNode = head;
            Node current = newHead;
            while (originCurrentNode != null)
            {
                var currentRandom = originCurrentNode.random;
                if (currentRandom != null)
                {
                    current.random = map[originCurrentNode.random];
                }
                //else{
                //    currentRandom.random = null;
                //}
                originCurrentNode = originCurrentNode.next;
                current = current.next;
            }

            return newHead;

        }



    }
}
