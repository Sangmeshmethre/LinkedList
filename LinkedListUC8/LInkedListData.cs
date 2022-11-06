using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC8
{
    public class LinkedListData
    {
        //head is used as node start point
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("Element added in linkedlist is : {0} ", +node.data);
        }

        //Append Method is also used to Add Elements at last

        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("After Appending element to lastly added element  : {0}", data);
        }


        //Insert method takes two parameters to insert element in between the Node

        public void Insert(int lastNode, Node NewData)
        {
            Node temp = head;

            //while loop to check if our temp is null then it return head
            //else it goes to another while loop

            while (temp != null)
            {
                while (temp.data == lastNode)
                {

                    Node newnode = temp.Next;
                    //store NewData to temp.Next

                    temp.Next = NewData;

                    temp.Next.Next = newnode;
                    break;
                }
                temp = temp.Next;
            }
        }

        //pop Method to delete First elements from the linked list

        public void pop()
        {
            if (head == null)
            {
                Console.WriteLine("linked List is Empty");
            }
            else
            {
                Node popped = head;
                head = head.Next;

            }
        }

        //Delete Last Element from the Linked List using PopLast Method

        public void popLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }

            Node newnode = head;

            while (newnode.Next.Next != null)
            {
                newnode = newnode.Next;
            }
            Node popLast = newnode.Next;
            newnode.Next = null;
        }

        //Search method

        public void Search(int data)
        {
            while (head != null)
            {
                if (head.data == data)
                {
                    Console.WriteLine("Searched element is present in linked list : {0}", data);
                }

                head = head.Next;
            }
        }

        //Display Method is Used to Display elements

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Console.WriteLine("Linked List contains :");

                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }
            }
        }
    }
}
