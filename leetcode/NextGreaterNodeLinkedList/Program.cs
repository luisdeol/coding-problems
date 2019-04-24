using System;
using System.Collections.Generic;

/*
    https://leetcode.com/problems/next-greater-node-in-linked-list/
*/
namespace NextGreaterNodeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 -> 7 -> 4 -> 3 -> 5 -> null
            var head = new ListNode(2);
            
            var node5 = new ListNode(5);
            var node4 = new ListNode(3) { next = node5 };
            var node3 = new ListNode(4) { next = node4 };
            var node2 = new ListNode(7) { next = node3 };
            head.next = node2;

            var solution = Solve(head);

            // [7, 0, 5, 5, 0]
            Console.Write("[");
            for (int i = 0; i < solution.Length - 1; i++) {
                Console.Write($"{solution[i]}, ");
            }

            Console.Write($"{solution[solution.Length - 1]}]\n");
        }

        public static int[] Solve(ListNode head) {
            var current = head;
            var nextGreaterNodeValue = new List<int>();
            
            while (current.next != null) {
                var innerCurrent = current.next;
                
                if (innerCurrent == null) {
                    break;
                }
                
                var altered = false;
                
                while (innerCurrent != null) {
                    if (innerCurrent.val > current.val) {
                        altered = true;
                        nextGreaterNodeValue.Add(innerCurrent.val);
                        break;
                    }
                    
                    innerCurrent = innerCurrent.next;
                }
                
                if (!altered) {
                    nextGreaterNodeValue.Add(0);
                }

                current = current.next;
            }
            
            nextGreaterNodeValue.Add(0);
            
            return nextGreaterNodeValue.ToArray();
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
