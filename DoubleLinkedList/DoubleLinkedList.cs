using System;
namespace DoubleLinkedList
{
    public class List
    {
        private Node start;
        public List()
        {
            start = null;
        }
        public void DisplayList()
        {
            if(start == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            Node p = start;
            Console.Write("The elements of the list are:");
            while(p!=null)
            {
                Console.Write(" " + p.info);
                p=p.next;
            }
            Console.WriteLine();
        }
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }
        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }
        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            Node p = start;
            while (p.next != null)
                p = p.next;
            p.next = temp;
            temp.prev = p;
        }
        public void InsertAfter(int data,int x)
        {
            Node p = start;
            while(p!=null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if (p==null)
            {
                Console.WriteLine("The element {0} is not found in the list", x);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                temp.prev = p;
                if (p.next != null)
                    p.next.prev = temp;
                p.next = temp;
            }
        }
        public void InsertBefore(int data, int x)
        {
            Node p = start;
            if (p == null)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Node temp = new Node(data);
                if (start.info==x)
                {
                    temp.next = start;
                    start.prev = temp;
                    start = temp;
                    return;
                }
                while (p != null)
                {
                    if (p.info == x)
                        break;
                    p = p.next;
                }
                if(p == null)
                {
                    Console.WriteLine("The element {0} is not found in the list", x);
                    return;
                }
                temp.next = p;
                temp.prev = p.prev;
                p.prev.next = temp;
                p.prev = temp;
            }
        }
        public void CreateList()
        {
            Console.Write("How many elements do you want in a list: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the first element you want to enter: ");
            int q = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(q);
            for(int i=2;i<=x;i++)
            {
                Console.Write("Enter the next element you want to enter: ");
                int p = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(p);
            }
            Console.WriteLine();
        }
        public void DeleteFirstNode()
        {
            Node p = start;
            start = p.next;
            p.next = null;
            Console.WriteLine("The first node is deleted");
            DisplayList();
        }
        public void DeleteLastNode()
        {
            Node p = start;
            while(p.next.next != null)
            {
                p = p.next;
            }
            p.next = null;
            Console.WriteLine("The last node is deleted");
            DisplayList();
        }
        public void DeleteAnyNode(int data)
        {
            Node p = start;
            while(p!=null)
            {
                if (p.info == data)
                    break;
                p = p.next;
            }
            p.prev.next = p.next;
            p.next.prev = p.prev;
            p.prev = null;
            p.next = null;
            Console.WriteLine("The node {0} is deleted",data);
            DisplayList();
        }
    }
}
