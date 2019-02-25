//using System;
//using SingleLinkedListproject;
//namespace SingleListMergingProject
//{
//    public class MergingAlgorithm
//    {
//        public static void Main(string[] args)
//        {
//            SingleLinkedList list1 = new SingleLinkedList();
//            SingleLinkedList list2 = new SingleLinkedList();
//            list1.CreateList();
//            list2.CreateList();
//            list1.BubbleSortExData();
//            list2.BubbleSortExData();
//            Console.WriteLine("The elements of list1 is -"); list1.DisplayList();
//            Console.WriteLine("The elements of list2 is -"); list2.DisplayList();
//            SingleLinkedList list3;
//            list3 = list1.Merge1(list2);
//            Console.WriteLine("The elements of list1 is -"); list1.DisplayList();
//            Console.WriteLine("The elements of list2 is -"); list2.DisplayList();
//            list3 = list1.Merge2(list2);
//            Console.WriteLine("The elements of list1 is -"); list1.DisplayList();
//            Console.WriteLine("The elements of list2 is -"); list2.DisplayList();
//        }
//    }
//}
