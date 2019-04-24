using System;

/*
    https://leetcode.com/problems/remove-duplicates-from-sorted-list/
*/
namespace RemoveDuplicatesSortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 -> 1 -> 2 -> 3 -> 3 -> null
            var head = new ListNode(1);
            
            var node5 = new ListNode(3);
            var node4 = new ListNode(3) { next = node5 };
            var node3 = new ListNode(2) { next = node4 };
            var node2 = new ListNode(1) { next = node3 };
            head.next = node2;

            var solution = Solve(head);

            // 1 -> 2 -> 3
            head.PrintList();
        }

        public static ListNode Solve(ListNode head) {
            var current = head;
        
            while (current != null) {
                while (current.next != null && current.val == current.next.val) {
                    current.next = current.next.next;
                }
                
                current = current.next;
            }
            
            return head;
        }
        
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int value)
        {   
            val = value;
        }

        public void PrintList() {
            var current = this;

            while (current != null) {
                Console.Write($"{current.val} -> ");
                current = current.next;
            }

            Console.Write("null\n");
        }
    }
}
