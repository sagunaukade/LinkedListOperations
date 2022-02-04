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
            Console.WriteLine("Welcome to the Linked List operation");
            Operation obj = new Operation();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertBetween(2, 30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*****Appending*****");
            obj.Display();
            Console.ReadLine();
        }
    }
}