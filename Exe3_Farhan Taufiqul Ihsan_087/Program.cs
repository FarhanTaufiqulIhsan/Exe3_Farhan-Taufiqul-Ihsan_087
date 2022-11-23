using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3_Farhan_Taufiqul_Ihsan_087
{
    class Node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        static void Main(string[] args)
        {
        }
    }
}
