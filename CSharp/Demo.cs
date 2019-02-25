using System;
using System.Collections.Generic;

namespace SingleLinkedListproject
{
    public class Demo
    {
        static void Main(string[] args)
        {
            int choice,k,data;
            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();
            while(true)
            {
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert an empty list/Insert in the beginning of the Linked list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete any node");
                Console.WriteLine("12.Reverse the list");
                Console.WriteLine("13.Buble sort by exchanging data");
                Console.WriteLine("14.Buble sort by exchanging links");
                Console.WriteLine("15.Merge sort");
                Console.WriteLine("16.Insert Cycle");
                Console.WriteLine("17.Detect Cycle");
                Console.WriteLine("18.Remove Cycle");
                Console.WriteLine("19.Quit");
                Console.WriteLine("20.Find the middle element");
                Console.WriteLine();
                try
                {
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 19)
                        break;

                    switch (choice)
                    {
                        case 1:
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 2:
                            list.CountNodes();
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Write("Enter the element to be searched");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.Search(k);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.Write("Enter the number that has to be inserted: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertInBeginning(k);
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.Write("Enter the number you want to insert: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertAtEnd(k);
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine("Insert the element you want to insert: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("After which element do you want to insert: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertAfter(data, k);
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine("Insert the element you want to insert: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Before which element do you want to insert: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertBefore(data, k);
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.WriteLine("Insert the element you want to insert: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("At which position do you want to insert: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertAtPosition(data, k);
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 9:
                            list.DeleteFirstNode();
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 10:
                            list.DeleteLastNode();
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 11:
                            Console.WriteLine("Which element in the list do you want to delete");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.DeleteNode(k);
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 12:
                            list.ReverseList();
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 13:
                            list.BubbleSortExData();
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 14:
                            list.BubbleSortExData();
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 15:
                            list.MergeSort();
                            list.DisplayList();
                            Console.WriteLine();
                            break;
                        case 16:
                            Console.Write("At which element do you want to insert the cycle= ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.InsertCycle(data);
                            Console.WriteLine();
                            break;
                        case 17:
                            if (list.IsCycle() == true)
                                Console.WriteLine("There is a cycle present in the list");
                            else
                                Console.WriteLine("There is no cycle present in the list");
                            Console.WriteLine();
                            break;
                        case 18:
                            if (list.IsCycle() == true)
                                list.RemoveCycle();
                            else
                                Console.WriteLine("There is no cycle present in the linked list!");
                            Console.WriteLine();
                            break;
                        case 20:
                            list.MiddleElement();
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
