using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC4
{
    public class Node
    {
        public int data;
        public Node Next;

        //Constructer of Node Class
        public Node (int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
