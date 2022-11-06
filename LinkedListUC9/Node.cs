using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC9
{
    public class Node
    {

        public int data;
        public Node Next;

        //constructor of Node class
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
