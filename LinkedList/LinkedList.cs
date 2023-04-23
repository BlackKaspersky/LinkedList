using System.Collections;


namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T>? head;
        public Node<T>? tail;
        public int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(T item)
        {
            var node = new Node<T>(item);

            if (head == null)
                head = node;

            else
                tail!.Next = node;

            tail = node;
            count++;
        }

        public void Remove(T item)
        {
            Node<T>? current = head;
            Node<T>? previous = null;

            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }

                    else
                    {
                        head = head?.Next;

                        if (head == null)
                        {
                            tail = null;
                        }
                    }

                    count--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
            return;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;

        }

        public void AppendFirst(T data)
        {
            Node<T>? node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }

        public bool Contains(T data)
        {
            Node<T>? current = head;
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }

}

