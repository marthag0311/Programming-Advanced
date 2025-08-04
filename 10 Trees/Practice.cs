using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Trees
{
    public class Practice
    {
        public Node Root { get; set; }

        public Practice()
        {
            Root = null;
        }

        public Practice(int value)
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

        private void Add(Node root, int value)
        {
            if (value < root.Value)
            {
                if (root.Left == null) root.Left = new Node(value);
                else Add(root.Left, value);
            }
            else
            {
                if (root.Right == null) root.Right = new Node(value);
                else Add(root.Right, value);

            }
        }
    }
}
