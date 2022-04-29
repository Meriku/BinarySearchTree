using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Tree<T>
                    where T : IComparable
    {

        public Node<T> Root { get; set; }
        
        public int Count { get; set; }

        public Tree () { }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Root.Add(node);
            Count++;

        }

        public List<T> Preorder()
        {

            if (Root == null)
            {
                return new List<T>(); ;
            }
            else
            {
                return Preorder(Root);
            }

        }
        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();

            list.Add(node.Data);

            if (node.Left != null)
            {
                list.AddRange(Preorder(node.Left));
            }

            if (node.Right != null)
            {
                list.AddRange(Preorder(node.Right));
            }

            return list;
        }


        public List<T> Postorder()
        {

            if (Root == null)
            {
                return new List<T>(); ;
            }
            else
            {
                return Postorder(Root);
            }

        }
        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();

            if (node.Left != null)
            {
                list.AddRange(Preorder(node.Left));
            }

            if (node.Right != null)
            {
                list.AddRange(Preorder(node.Right));
            }

            list.Add(node.Data);

            return list;
        }

        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>(); ;
            }
            else
            {
                return Inorder(Root);
            }
        }
        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();

            if (node.Left != null)
            {
                list.AddRange(Inorder(node.Left));
            }

            list.Add(node.Data);

            if (node.Right != null)
            {
                list.AddRange(Inorder(node.Right));
            }
          
            return list;
        }

    }
}
