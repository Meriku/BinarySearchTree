using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T> : IComparable
                    where T:IComparable
                    // Вместо дженерика T можно использовать только те типы которые поддерживают операции сравнения
    {

        public T Data { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data=data;
            Left = left;
            Right = right;
        }

        public void Add(Node<T> node)
        {

            if (node < this)         // Если новый элемент меньше чем текущий -> добавляем влево
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(node);
                }
            }
            else                    // Иначе -> добавляем вправо
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(node);
                }
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item.Data);
            }
            else
            {
                throw new ArgumentException("Type is not available");
            }
        }
        public static bool operator< (Node<T> first, Node<T> second)
        {

            if (first.Data.CompareTo(second.Data) == -1)
            {
                return true;
            }

            return false;
        }
        public static bool operator> (Node<T> first, Node<T> second)
        {

            if (first.Data.CompareTo(second.Data) == 1)
            {
                return true;
            }

            return false;
        }
    }
}
 