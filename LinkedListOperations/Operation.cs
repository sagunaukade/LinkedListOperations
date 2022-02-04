using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOperations
{
    internal class Operation
    {
        //Creating a head node to point the first element
        public Node head;
        //Creating a method to insert last 

        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list from last " + new_node.data);
        }
        //Insert Front 
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted the list in front " + new_node.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Appending a new node
        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.data = new_data;//assign data element
            new_node.next = null;//assign null to next of new node
            //check linkedlist empty 
            if (head == null)
            {
                head = new_node;

            }
            else
            {
                //traverse to last node
                Node temp = new Node(new_data);
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;

            }



        }
        public void InsertBetween(int pos, int new_data)
        {
            Node newNode = new Node(new_data);
            if (pos == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else if (pos <= 0)
            {
                Console.WriteLine("Invalid Position!!!");
            }
            else if (pos > 0)
            {
                Node temp = head;
                while (pos != 0)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine(" insertion performed between two nodes");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                    pos--;
                }

            }
        }
        //Deleting first element
        //Deleting the first node
        public Node DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        //Delete Last element
        public Node DeleteLast()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;

        }
        //Searching the particular element in linked list
        public Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Element found.. " + value);
                    return temp;
                }
                temp = temp.next;

            }
            Console.WriteLine("Element not found!!!!!!!!");
            return default;
        }
        //Searching the particular element
        //-->If element is found,then after that insert the element..
        public int Insert(int searchdata, int data)
        {
            Node temp = Search(searchdata);
            Node newNode = new Node(data);
            newNode.next = temp.next;
            temp.next = newNode;
            return (newNode.data);

        }
        //search and delete
        public int DeleteInBetween(int data)
        {
            Node temp = Search(data);
            Console.WriteLine("Data {0} has been deleted from linked list", temp.data);
            temp.next = temp.next.next;
            int sizeofList = Size();
            return sizeofList;
        }
        public int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
       
        //Display the nodes
        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
    
}
    


            