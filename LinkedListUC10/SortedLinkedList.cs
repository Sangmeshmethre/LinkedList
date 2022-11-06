using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC10
{
    //Refactor Class
    public class SortedLinkedList
    {
        public Node head;

        //creating constructor
        public SortedLinkedList()
        {
            this.head = null;
        }


        //Add method by using sorting
        public void Add(int data)
        {
            Node node = new Node(data);

            Node present = head;
            Node lastNode = null;

            while (present != null && present.data < node.data)
            {
                lastNode = present;
                present = present.Next;
            }
            if (lastNode == null)
            {
                head = node;
            }
            else
            {
                lastNode.Next = node;
            }
            node.Next = present;
            Console.WriteLine(node.data);
        }
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
