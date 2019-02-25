using System;

namespace DoubleLinkedList
{
    class Demo
    {
        public static void Main(string[] args)
        {
            int choice,data,x;
            List list = new List();
            list.CreateList();
            
           while(true)
            {
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Insert an empty list");
                Console.WriteLine("3.Insert a node at the beginning of the list");
                Console.WriteLine("4.Insert a node at the end of the list");
                Console.WriteLine("5.Insert a node after a specified node");
                Console.WriteLine("6.Insert a node before a specified node");
                Console.WriteLine("7.Delete first node");
                Console.WriteLine("8.Delete last node");
                Console.WriteLine("9.Delete any node");
                Console.WriteLine("10.Reverse the list");
                Console.WriteLine("11.Quit");
                Console.WriteLine();
                Console.Write("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 11)
                    break;
                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter the number you want to insert in the begining of the list: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.Write("Enter the number you want to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Before which number do you want to insert the node: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter the number which you want to enter in an empty list: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter the number which you want to insert at the end of the list: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Write("Enter the number which you want to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the number after which you want to insert in the list: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        Console.WriteLine();
                        break;
                    case 7:
                        list.DeleteFirstNode();
                        Console.WriteLine();
                        break;
                    case 8:
                        list.DeleteLastNode();
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.Write("Which number do you want to delete in the list: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteAnyNode(data);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
