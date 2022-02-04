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
            //UseCase 1
            Operation obj = new Operation();
            //Insertion Operation
            obj.InsertFront(56);
            obj.InsertFront(30);
            obj.InsertFront(70);
            //Display Operation
            Console.WriteLine("Insertion at First");
            obj.Display();
            Console.ReadLine();


        }
    }
}
