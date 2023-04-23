﻿namespace LinkedList
{
    public class Node<T>
    {
        public T Data { get; private set; }

        public Node<T>? Next { get; set; }


        public Node(T data)
        {
            Data = data;
        }

    }
}
