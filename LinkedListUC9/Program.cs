using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problems");

            bool check = true;

        Start:
            while (check)
            {
                Console.WriteLine("Please Select options :\n" +
                    "1)Elements Added in the Linked List using Add Method\n" +
                    "2)Elements Appended in the linked List to Last using Append Method\n" +
                    "3)Element Inserted At a Particular Position Using Insert \n" +
                    "4)First Element Deleted from the list using pop Method\n" +
                    "5)Last Element Deleted from the List using popLast Method\n" +
                    "6)Search for a Particular Element using Search Method from the List\n" +
                    "7)Insert Element at a Particular Position after Searching by using Insert and Search Method\n" +
                    "8)Delete Element from a particular Position and get a Size of the Linked List\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list = new LinkedListData();
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 2:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list1 = new LinkedListData();
                        list1.Add(56);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list1.Append(30);
                        list1.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list1.Append(70);
                        list1.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list1.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 3:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list2 = new LinkedListData();
                        list2.Add(56);
                        list2.Add(70);
                        //creating object of Node class and passing data 
                        //here 30 is Inserted into the list
                        Node node = new Node(30);
                        Console.WriteLine("Element inserted in between the list after 56 : {0}", node.data);
                        Console.WriteLine("So After inserting the Final list appears as :");
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list2.Insert(56, node);
                        list2.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 4:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list3 = new LinkedListData();
                        list3.Add(56);
                        list3.Add(30);
                        list3.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list3.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("First Element Popped out from the list");
                        list3.pop();
                        list3.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 5:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list4 = new LinkedListData();
                        list4.Add(56);
                        list4.Add(30);
                        list4.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list4.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Last Element Popped out from the list");
                        list4.popLast();
                        list4.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 6:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list5 = new LinkedListData();
                        list5.Add(56);
                        list5.Add(30);
                        list5.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list5.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("After searching for a Particular Element ");
                        list5.Search(30);

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 7:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list6 = new LinkedListData();
                        list6.Add(56);
                        list6.Add(30);
                        list6.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list6.Display();

                        //creating object of Node class and passes parameter which we want to insert
                        //here 40 is Inserted into the list
                        Node node1 = new Node(40);
                        Console.WriteLine("Element inserted in between the list after 30 -> {0}", node1.data);
                        Console.WriteLine("So After inserting, the Final list appears as :");
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list6.Insert(30, node1);
                        list6.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 8:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list7 = new LinkedListData();
                        list7.Append(56);
                        list7.Append(30);
                        list7.Append(40);
                        list7.Append(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list7.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.Write("Deleting 40 from the list now " + " ");
                        list7.delElement(40);
                        list7.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.Write("Size of the linked list is : ");
                        list7.size();

                        break;


                    default:
                        Console.WriteLine("Please select proper option");
                        break;

                        goto Start;

                }

            }

        }
    }
}