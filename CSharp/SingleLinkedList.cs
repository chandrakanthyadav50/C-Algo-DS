using System;

namespace SingleLinkedListproject
{
    public class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("The List is empty");
                return;
            }
            Console.Write("List is: ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
        public void CountNodes()
        {
            int n = 0;
            Node p;
            p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("The number of nodes present in the linked list are ={0}", n);
        }
        public bool Search(int x)
        {
            Node p = start;
            int position = 1;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine("The value {0} is not found in the list", x);
                return false;
            }
            else
            {
                Console.WriteLine("The value {0} is found at position {1}", x, position);
                return true;
            }
        }
        public void InsertInBeginning(int data) //Also works to insert a node in an empty list.
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }
        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while (p.link != null)
                p = p.link;
            p.link = temp;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.WriteLine("Enter the number of elements you want to insert: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                return;
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
            Console.WriteLine();
        }
        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine("The number {0} is not found in the list", x);
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void InsertBefore(int data, int x)
        {
            Node temp;
            if (start == null)
            {
                Console.WriteLine("The list is empty");
            }
            else if (start.info == x)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
            }
            else
            {
                Node p = start;
                while (p.link != null)
                {
                    if (p.link.info == x)
                        break;
                    p = p.link;
                }
                if (p.link == null)
                {
                    Console.WriteLine("The number {0} is not present in the list", x);
                }
                else
                {
                    temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;
                }
            }
        }
        public void InsertAtPosition(int data, int x)
        {
            Node temp;
            int i;

            if(x == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i=1;i<x-1 && p!=null;i++)
            {
                p = p.link;
            }
            if (p == null) 
            {
                Console.WriteLine("You can insert only upto position {0}", i);
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }
        public void DeleteLastNode()
        {
            if (start == null)
                return;
            if (start.link == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while(p.link.link != null)
            {
                p = p.link;
            }
            p.link = null;
        }
        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            if(start.info == x)
            {
                start = start.link;
                return;
            }
            Node p = start;
            while(p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if(p.link == null)
            {
                Console.WriteLine("The element {0} is not there in the list", x);
                return;
            }
            p.link = p.link.link;
        }
        public void ReverseList()
        {
            Node prev, p, next;
            p = start;
            if (p == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            prev = null;
            while(p!=null)
            {

                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start=prev;
        }
        public void BubbleSortExData()
        {
            Node p, q, end;
            for (end=null;end != start.link;end=p)
            {
                for(p=start;p.link != end;p=p.link)
                {
                    q = p.link;
                    if(p.info > q.info)
                    {
                        int temp;
                        temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }
        public void BubbleSortExLink()
        {
            Node r, p, q, end, temp;
            for(end=null;end!=start.link;end=p) 
            {
                for (r = p = start; p.link != end;r=p,p=p.link)
                {
                    q = p.link;
                    if(p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (r != start)
                            r.link = q;
                        else
                            start = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }
        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }
        private Node Merge1(Node p1,Node p2)
        {
            Node startM;
            if(p1.info <= p2.info)
            {
                startM = new Node(p1.info);
                p1 = p1.link;
            }
            else
            {
                startM = new Node(p2.info);
                p2 = p2.link;
            }
            Node pM = startM;
            while(p1 != null && p2 != null)
            {
                if(p1.info <= p2.info)
                {
                    pM.link = new Node(p1.info);
                    p1 = p1.link;
                }
                else
                {
                    pM.link = new Node(p2.info);
                    p2 = p2.link;
                }
                pM = pM.link;
            }
            while(p1!= null)
            {
                pM.link = new Node(p1.info);
                p1 = p1.link;
                pM = pM.link;
            }
            while(p2!=null)
            {
                pM.link = new Node(p2.info);
                p2 = p2.link;
                pM = pM.link;
            }
            return startM;
        }
        public SingleLinkedList Merge2(SingleLinkedList list)
        {
            SingleLinkedList mergelist = new SingleLinkedList();
            mergelist.start = Merge2(start, list.start);
            return mergelist;
        }
        private Node Merge2(Node p1,Node p2)
        {
            Node startM=null;
            if(p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }
            Node pM = startM;
            while(p1!=null && p2!=null)
            {
                if(p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }
            if (p1 == null)
                pM.link = p2;
            else
                pM.link = p1;
            return startM;
        }
        public void MergeSort()
        {
            start = MergeSortRec(start);
        }
        private Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null)
                return listStart;
            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
        }
        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while(q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;
            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }
        public bool IsCycle()
        {
            if (FindCycle() == null)
                return false;
            else
                return true;
        }
        private Node FindCycle()
        {
            if (start == null || start.link == null)
                return null;
            Node slowR = start, fastR = start;
            while(fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                    return slowR;
            }
            return null;
        }
        public void RemoveCycle()
        {
            if(IsCycle()==true)
            {
                Node c = FindCycle();
                int cyclenodes = 0;
                Node p = c, q = c;
                do
                {
                    cyclenodes++;
                    q = q.link;
                } while (p != q);
                Console.WriteLine("The number of values in the cycle is={0}", cyclenodes);
                int outnodes = 0;
                p = start;
                while (p != q)
                {
                    outnodes++;
                    p = p.link;
                    q = q.link.link;
                }
                Console.WriteLine("The number of nodes outside the cycle is={0}", outnodes);
                int listnodes = cyclenodes + outnodes;
                p = start;
                for (int i = 1; i < listnodes - 1; i++)
                    p = p.link;
                p.link = null;
                Console.WriteLine("The cycle is removed :)");
            }
            else
            {
                Console.WriteLine("There is no cycle present in the list to remove");
            }
        }
        public void InsertCycle(int x)
        {
            Node p = start, q = start;
            while(p.link!=null)
            {
                p = p.link;
            }
            while(q!=null)
            {
                if (q.info == x)
                    break;
                q = q.link;
            }
            if (q == null)
                Console.WriteLine("The element is not present in the list");
            else
                p.link = q;
                Console.WriteLine("Cycle is inserted:) ");
        }
        public void MiddleElement()
        {
            int m;
            int n=1;
            Node p = start;
            while(p.link!=null)
            {
                p=p.link;
                n++;
            }
            Console.WriteLine("The number of elements in the list are: {0}", n);
            if (n % 2 != 0)
            {
                m = n / 2 + 1;
                Node q = start;
                for (int i = 1; i < m; i++)
                    q = q.link;
                Console.WriteLine("The middle element is: {0}", q.info);
            }
            else
            {
                Console.WriteLine("There is no middle element");
            }

        }
    }
}

