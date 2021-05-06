using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
 
 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }


    public static class MergeSortedArrays
    {


        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode head;
            ListNode tail;
            if (l1.val <= l2.val)
            {
                Console.WriteLine($"{l1.val}:{l2.val}");
                head = l1;
                tail = l1;
                l1 = l1.next;
            }
            else
            {
                Console.WriteLine($"{l1.val}:{l2.val}");
                head = l2;
                tail = l2;
                l2 = l2.next;
            }

            while (l1 != null && l2 != null)
            {
                Console.WriteLine($"{l1.val}:{l2.val}");
                if (l1.val <= l2.val)
                {
                    tail.next = l1;
                    l1 = l1.next;

                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }

            while (l1 != null)
            {
                tail.next = l1;
                l1 = l1.next;
                tail = tail.next;
            }

            while (l2 != null)
            {
                tail.next = l2;
                l2 = l2.next;
                tail = tail.next;
            }

            return head;

        }



    }
}
