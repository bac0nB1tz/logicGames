using System.Collections.Generic;

namespace mergeTwoSortedLists
{
    class Program
    {
        static LinkedListNode<int> mergeTwoLists(LinkedListNode<int> lln1, LinkedListNode<int> lln2){
            
            if(lln1 == null)
                return lln2;
            if(lln2 == null)
                return lln1;
            
            LinkedListNode<int>? mergeHead = null;

            if(lln1.Value <= lln2.Value){
                mergeHead = lln1;
                lln1 = lln1.Next;
            } else {
                mergeHead = lln2;
                lln2 = lln2.Next;
            }

            LinkedListNode<int>? mergeTail = null;

            while(lln1 != null && lln2 != null){
                LinkedListNode<int> temp = null;

                if(lln1.Value <= lln2.Value){
                    temp = lln1;
                    lln1 = lln1.Next;
                } else {
                    temp = lln2;
                    lln2 = lln2.Next;
                }

                mergeTail.Next = temp;
            }

            Console.WriteLine(lln1.Value);
            Console.WriteLine(lln2.Value);
            
        }

        static void Main(string[] args)
        {
            int[] arr1 = {4,8,15,19};
            int[] arr2 = {7,9,10,16};

            LinkedList<int> ll1 = new LinkedList<int>(arr1);
            LinkedList<int> ll2 = new LinkedList<int>(arr2);

            Console.WriteLine(mergeTwoLists(ll1.First,ll2.First));
        }
    }
}