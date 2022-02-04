using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Operations");
            Console.WriteLine("****WELCOME TO LINKED LIST OPERATIONS");
            Console.WriteLine("\n1.Inserted into list(From Last)");
            Console.WriteLine("\n2.Inserted into list(Front)");
            Console.WriteLine("\n3.Inserting in middle");
            Console.WriteLine("\n4.Delete the First Element");
            Console.WriteLine("\n5.Delete the Last Element");
            Console.WriteLine("\n6.Searching the Element");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            //Creating object for Custom Linked list class
            Operation obj = new Operation();
            switch (num)
            {
                case 1:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    break;
                case 2:
                    obj.InsertFront(56);
                    obj.InsertFront(30);
                    obj.InsertFront(70);
                    obj.Display();
                    break;
                case 3:
                    obj.InsertLast(56);
                    obj.InsertLast(70);
                    obj.InsertBetween(2, 30);
                    obj.Display();
                    break;
                case 4:
                    obj.InsertFront(56);
                    obj.InsertFront(30);
                    obj.InsertFront(70);
                    obj.DeleteFirst();
                    obj.Display();
                    break;


            }
            Console.ReadLine();
        }
    }
}