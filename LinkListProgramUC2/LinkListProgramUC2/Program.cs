using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProgramUC2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To LinkList Oparation");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}