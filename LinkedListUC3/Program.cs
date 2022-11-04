using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC3
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
                    "2)Elements Appended in the linked List to Last using Append Method\n");

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


                    default:
                        Console.WriteLine("Please select proper option");
                        break;

                        goto Start;

                }

            }

        }
    }
}