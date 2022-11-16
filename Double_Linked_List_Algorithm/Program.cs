using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List_Algorithm
{
    class Node
    {
        /* Node class represents the node of doubly linked list.
         * It consists of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of next and previous nodes,
         */
        public int rollNumber;
        public string name;
        public Node next;
        public Node prev;
    }
}
