using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Node<T>
    {
        T data;
        Node<T> link;
        public Node(T data, Node<T> link)
        {
            this.data = data;
            this.link = link;
        }
    }
}
