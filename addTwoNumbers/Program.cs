namespace HelloWorld
{

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/add-two-numbers/
            var end = new ListNode(3);
            var mid = new ListNode(4);
            mid.next = end;
            var l1 = new ListNode(9,mid);

            var end2 = new ListNode(4);
            var mid2 = new ListNode(6);
            mid2.next = end2;
            var l2 = new ListNode(9,mid2);

            var result = AddTwoNumbers(l1,l2);
            Console.WriteLine(result);

        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode dummyHead = new ListNode(0);
            ListNode curr = dummyHead;
            int carry = 0;
            
            while (l1 != null || l2 != null || carry != 0) {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            return dummyHead.next;
        }
    }

}