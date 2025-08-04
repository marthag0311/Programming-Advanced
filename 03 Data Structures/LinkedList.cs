using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Data_Structures
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(Node head)
        {
            Head = head;
        }

        //Return the last empty element/node
        private Node Last()
        {
            Node iterator = Head; // the iterator always starts at the beginning

            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }
            return iterator;
        }

        //Insert in an empty Linked List
        public void Insert(Node node)
        {
            //Inster the first element/node => Check if the first element/node is empty
            if (Head == null)
            {
                Head = node;
            }
            //Insert the last element/node => Take the last empty address
            else
            {
                Last().Next = node;
            }
        }

        public override string ToString()
        {
            if (Head == null) return "Empty list!";
            
            string list = "";
            Node iterator = Head; // the iterator always starts at the beginning
            while (iterator.Next != null)
            {
                list += $"{iterator.Data} --> ";
                iterator = iterator.Next;
            }
            list += $"{iterator.Data} --> ";
            return list;
        }

        //Search the data 
        public bool Search(int data)
        {
            Node iterator = Head; // the iterator always starts at the beginning
            while (iterator.Next != null)
            {
                if (iterator.Data == data) return true;
                iterator = iterator.Next;
            }
            return false;
        }

        //Deleting
        public void Delete(int data)
        {
            //Delete the first element/node => replace it by the second node/elemnt
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            //Delete the middle element/node => by bypassing it 

            Node iterator = Head; // the iterator always starts at the beginning
            while (iterator.Next != null)
            {
                if (iterator.Data == data)
                {
                    iterator.Next = iterator.Next.Next;
                    return;
                }
            }
        }
    }
}
