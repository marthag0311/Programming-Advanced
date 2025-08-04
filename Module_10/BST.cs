using System;
using System.Collections.Generic;

namespace Module_10
{
    public class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            Root = null;
        }

        public BST(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else Add(Root, value);
        }

        private void Add(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null) node.Left = new Node(value);
                else Add(node.Left, value);
            }
            else
            {
                if (node.Right == null) node.Right = new Node(value);
                else Add(node.Right, value);

            }
        }

        public void Delete(int value)
        {
            if (Root != null) Root = Delete(Root, value);
        }

        private Node Delete(Node node, int value)
        {
            if (node == null) return node;

            if (value < node.Value) node.Left = Delete(node.Left, value);
            else if (value > node.Value) node.Right = Delete(node.Right, value);
            else
            {
                if (node.Left == null) return node.Right;
                else if (node.Right == null) return node.Left;

                node.Value = MinValue(node.Right);
                node.Right = Delete(node.Right, node.Value);
            }
            return node;
        }

        private int MinValue(Node node)
        {
            int min = node.Value;
            while (node.Left != null)
            {
                min = node.Left.Value;
                node = node.Left;
            }
            return min;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public void TraverseInOrder()
        {
            if (IsEmpty()) Console.WriteLine("Tree is empty!");
            else
            {
                TraverseInOrder(Root);
                Console.WriteLine();
            }
        }

        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left);
                Console.Write($"{node.Value} ");
                TraverseInOrder(node.Right);
            }
        }
    }
}