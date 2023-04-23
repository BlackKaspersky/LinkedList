namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.AppendFirst(4);
            Console.WriteLine(myList.Contains(2));
            WriteLinkedList(myList);
            Console.WriteLine();
            myList.Remove(2);
            WriteLinkedList(myList);
            Console.WriteLine();
            myList.Clear();

        }
        public static void WriteLinkedList(LinkedList<int> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}